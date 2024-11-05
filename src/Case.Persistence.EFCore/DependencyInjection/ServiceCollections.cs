using Case.Persistence.EFCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Case.Persistence.EFCore.DependencyInjection;

public static class ServiceCollections
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
        services.AddDbContext<CaseDbContext>(optionsBuilder =>
        {
            var connectionString = configuration.GetConnectionString("AppDb")
                                   ?? throw new InvalidOperationException("Could not get database connection string");

            var dbProvider = configuration.GetValue<string>("DbProvider");
            
            switch (dbProvider)
            {
                case "SqlServer":
                    optionsBuilder.UseSqlServer(connectionString);
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

        // services.AddScoped<IEngageRequestDocumentRepository, EngageRequestDocumentRepository>();
        // services.AddScoped<IMatterRepository, MatterRepository>();
        // services.AddScoped<IVolumeRepository, VolumeRepository>();

        return services;
    }

    private static IServiceCollection AddServices(this IServiceCollection services)
    {
        return services;
    }
}