using Case.Persistence.EFCore;
using Case.Persistence.EFCore.SqlServer;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;

namespace Case.Infrastructure.DependencyInjection;

public static class ServiceCollections
{
    public static IServiceCollection AddInfrastructureServices(this IServiceCollection services,
        IConfiguration configuration)
    {
        services.AddScoped<SqlServerProviderSetup>();  // Register SqlServerProviderSetup
        services.AddPersistence(configuration);
        services.AddServices();

        return services;
    }

    private static IServiceCollection AddPersistence(this IServiceCollection services, IConfiguration configuration)
    {
        services.AddDbContext<CaseDbContext>((serviceProvider, optionsBuilder) =>
        {
            var connectionString = configuration.GetConnectionString("AppDb")
                                   ?? throw new InvalidOperationException("Could not get database connection string");

            var dbProvider = configuration.GetValue<string>("DbProvider");

            switch (dbProvider)
            {
                case "SqlServer":
                    var sqlServerSetup = serviceProvider.GetRequiredService<SqlServerProviderSetup>();
                    sqlServerSetup.Setup(optionsBuilder, connectionString);
                    break;
                case "Sqlite":
                    optionsBuilder.UseSqlite(connectionString);
                    break;
                case "PostgreSql":
                    optionsBuilder.UseNpgsql(connectionString);
                    break;
                default:
                    throw new InvalidOperationException("Invalid database provider");
            }
        });

        // Register other repositories here, e.g.,
        // services.AddScoped<IEngageRequestDocumentRepository, EngageRequestDocumentRepository>();
        // services.AddScoped<IMatterRepository, MatterRepository>();
        // services.AddScoped<IVolumeRepository, VolumeRepository>();

        return services;
    }

    private static IServiceCollection AddServices(this IServiceCollection services)
    {
        // Register any additional services here
        return services;
    }
}