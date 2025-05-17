using AccountManagement.EndPoint.Api.Extentions;
using Framework.AuthHelper;
using Microsoft.AspNetCore.Authentication.Cookies;
using Zamin.Extensions.DependencyInjection;
using Zamin.Utilities.SerilogRegistration.Extensions;

SerilogExtensions.RunWithSerilogExceptionHandling(() =>
{
    var builder = WebApplication.CreateBuilder(args);

    builder.Services.Configure<CookiePolicyOptions>(options =>
    {
        options.CheckConsentNeeded = context => true;
        options.MinimumSameSitePolicy = SameSiteMode.Lax;
    });

    builder.Services.AddAuthentication(CookieAuthenticationDefaults.AuthenticationScheme)
                .AddCookie(CookieAuthenticationDefaults.AuthenticationScheme, o =>
                {
                    o.LoginPath = new PathString("/Account");
                    o.LogoutPath = new PathString("/Account");
                });

    builder.Services.AddAuthorization(options =>
    {
        options.AddPolicy("AdminArea",
            builder => builder.RequireRole(new List<string> { Roles.Administator, Roles.ContentUploader }));

        options.AddPolicy("Shop",
            builde => builde.RequireRole(new List<string> { Roles.Administator }));

        options.AddPolicy("Account",
            builde => builde.RequireRole(new List<string> { Roles.Administator }));
    });

    var app = builder.AddZaminSerilog(o =>
    {
        o.ApplicationName = builder.Configuration.GetValue<string>("ApplicationName");
        o.ServiceId = builder.Configuration.GetValue<string>("ServiceId");
        o.ServiceName = builder.Configuration.GetValue<string>("ServiceName");
        o.ServiceVersion = builder.Configuration.GetValue<string>("ServiceVersion");
    }).ConfigureServices().ConfigurePipeline();
    app.Run();
});