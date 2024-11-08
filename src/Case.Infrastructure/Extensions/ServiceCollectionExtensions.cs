using Case.Core.Repositories;
using Case.Persistence.EFCore;
using Case.Persistence.EFCore.Repositories;
using Case.Persistence.EFCore.SqlServer;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Case.Infrastructure.Extensions;

public static class ServiceCollectionExtensions
{
    public static IServiceCollection AddInfrastructureServices(this IServiceCollection services,
        IConfiguration configuration)
    {
        services.AddPersistence(configuration);
        services.AddServices();

        return services;
    }

    private static IServiceCollection AddPersistence(this IServiceCollection services, IConfiguration configuration)
    {
        var providerName = configuration.GetValue<string>("DbProvider");
        var connectionString = configuration.GetConnectionString("AppDb");

        // Register the appropriate IDbProviderConfigurator based on providerName
        switch (providerName)
        {
            case "SqlServer":
                services.AddSingleton<IDbProviderConfigurator, SqlServerDbProviderConfigurator>();
                break;
            default:
                throw new InvalidDataException($"The provider {providerName} is not supported.");
        }

        // Configure ApplicationDbContext with the selected provider configurator
        services.AddDbContext<CaseDbContext>((serviceProvider, options) =>
        {
            var configurator = serviceProvider.GetRequiredService<IDbProviderConfigurator>();
            configurator.Configure(options, connectionString);
        });
        
        // Register other repositories here, e.g.,
        services.AddScoped<IMatterRepository, MatterRepository>();
        services.AddScoped<IUserRepository, UserRepository>();
        services.AddScoped<IWorkTypeRepository, WorkTypeRepository>();

        return services;
    }

    private static IServiceCollection AddServices(this IServiceCollection services)
    {
        // Register any additional services here
        return services;
    }
}