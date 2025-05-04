using AccountManagement.EndPoint.Api.CustomDecorators;
using AccountManagement.EndPoint.Api.Extentions.DependencyInjection.Swaggers.Extentions;
using Microsoft.AspNetCore.Cors.Infrastructure;
using Microsoft.EntityFrameworkCore;
using Serilog;
using ShopManagement.Infra.Data.Sql.Commands.Common;
using ShopManagement.Infra.Data.Sql.Queries.Common;
using Zamin.Core.ApplicationServices.Commands;
using Zamin.Core.ApplicationServices.Events;
using Zamin.Core.ApplicationServices.Queries;
using Zamin.EndPoints.Web.Extensions.ModelBinding;
using Zamin.Extensions.DependencyInjection;
using Zamin.Infra.Data.Sql.Commands.Interceptors;

namespace AccountManagement.EndPoint.Api.Extentions;

public static class HostingExtensions
{
    public static WebApplication ConfigureServices(this WebApplicationBuilder builder)
    {
        IConfiguration configuration = builder.Configuration;

        builder.Services.AddSingleton<CommandDispatcherDecorator, CustomCommandDecorator>();
        builder.Services.AddSingleton<QueryDispatcherDecorator, CustomQueryDecorator>();
        builder.Services.AddSingleton<EventDispatcherDecorator, CustomEventDecorator>();

        builder.Services.AddZaminApiCore("Zamin", "ZaminTemplate");

        builder.Services.AddEndpointsApiExplorer();

        builder.Services.AddZaminWebUserInfoService(configuration, "WebUserInfo", true);

        builder.Services.AddZaminParrotTranslator(configuration, "ParrotTranslator");

        builder.Services.AddNonValidatingValidator();

        builder.Services.AddZaminMicrosoftSerializer();

        builder.Services.AddZaminAutoMapperProfiles(configuration, "AutoMapper");

        builder.Services.AddZaminInMemoryCaching();

        builder.Services.AddDbContext<ShopManagementCommandDbContext>(
            c => c.UseSqlServer(configuration.GetConnectionString("CommandDb_ConnectionString"))
            .AddInterceptors(new SetPersianYeKeInterceptor(),
                             new AddAuditDataInterceptor()));

        builder.Services.AddDbContext<ShopManagementQueryDbContext>(
            c => c.UseSqlServer(configuration.GetConnectionString("QueryDb_ConnectionString")));

        builder.Services.AddSwagger(configuration, "Swagger");

        return builder.Build();
    }

    public static WebApplication ConfigurePipeline(this WebApplication app)
    {
        app.UseZaminApiExceptionHandler();

        app.UseSerilogRequestLogging();

        app.UseSwaggerUI("Swagger");

        app.UseStatusCodePages();

        app.UseCors(delegate (CorsPolicyBuilder builder)
        {
            builder.AllowAnyOrigin();
            builder.AllowAnyHeader();
            builder.AllowAnyMethod();
        });

        app.UseHttpsRedirection();

        var controllerBuilder = app.MapControllers();

        return app;
    }
}