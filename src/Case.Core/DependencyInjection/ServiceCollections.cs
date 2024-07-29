using Case.Core.Services;
using Microsoft.Extensions.DependencyInjection;

namespace Case.Core.DependencyInjection;

public static class ServiceCollections
{
    public static IServiceCollection AddCoreServices(this IServiceCollection services)
    {
        services
            .AddServices();

        return services;
    }

    private static IServiceCollection AddServices(this IServiceCollection services)
    {
        services.AddScoped<IMatterService, MatterService>();
        services.AddScoped<IUserService, UserService>();
        services.AddScoped<IWorkTypeService, WorkTypeService>();

        return services;
    }
}