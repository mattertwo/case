using Case.Infrastructure.Persistence;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Case.Infrastructure.DependencyInjection;


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
            var connectionString = configuration.GetConnectionString("CaseDb")
                                   ?? throw new InvalidOperationException("Could not get database connection string");

            optionsBuilder.UseSqlServer(connectionString);
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