using Microsoft.OpenApi.Models;
using Ocelot.DependencyInjection;
using Ocelot.Middleware;
using Ocelot.Provider.Polly;
using System.Net;
using System.Reflection;
using System.Web;

var builder = WebApplication.CreateBuilder(args);

builder.Configuration.AddJsonFile($"Ocelot.json", optional: false, reloadOnChange: true);
builder.Configuration.AddUserSecrets(Assembly.GetExecutingAssembly(), optional: true);



builder.Services.AddSwaggerGen(c =>
{
    c.SwaggerDoc("v1", new OpenApiInfo { Title = "ApiGateway", Version = "v1" });

    //c.ExampleFilters();
});

builder.Services.AddOcelot().AddDelegatingHandler<IgnoreSSLValidationHandler>().AddPolly();

builder.Services.AddCors(options => options.AddPolicy("CorsPolicy",
           builder =>
           {
               builder.AllowAnyHeader()
                      .AllowAnyMethod()
                      .SetIsOriginAllowed(_ => true)
                      .AllowCredentials();
           }));

ServicePointManager.ServerCertificateValidationCallback += (sender, cert, chain, error) => true;

var app = builder.Build();


if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    app.UseHsts();
}

app.UseCors("CorsPolicy");

app.UseSwagger();
app.UseSwaggerUI(c =>
{
    c.SwaggerEndpoint("/ApiGateway/swagger.json", "ApiGateway");

    c.SwaggerEndpoint("/AccountManagement/swagger.json", "AccountManagement");
    c.SwaggerEndpoint("/InventoryManagement/swagger.json", "InventoryManagement");
    c.SwaggerEndpoint("/ShopManagement/swagger.json", "ShopManagement");

    c.RoutePrefix = String.Empty;
    c.OAuthUsePkce();
});


var configuration = new OcelotPipelineConfiguration()
{
    PreErrorResponderMiddleware = async (ctx, next) =>
    {
        if (ctx.Request.Path.Equals(new PathString("/ConnectionCheck")))
        {
            if (ctx.Request.QueryString.HasValue)
            {
                var returnUrl = HttpUtility.ParseQueryString(ctx.Request.QueryString.Value).Get("returnUrl");
                if (returnUrl is not null)
                {
                    ctx.Response.Redirect(returnUrl);
                }
                else
                    await ctx.Response.WriteAsync("Ok");
            }
            else
                await ctx.Response.WriteAsync("Ok");
        }
        else
        {
            await next.Invoke();
        }
    }
};

app.UseWebSockets();
app.UseOcelot(configuration).Wait();

app.UseRouting();
app.UseEndpoints(endpoints =>
{
    endpoints.MapDefaultControllerRoute();
});

app.Run();
