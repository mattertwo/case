// Case.Core.Extensions/ServiceCollectionExtensions.cs
using Case.Core.Services;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Case.Core.Extensions
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection AddCoreServices(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddScoped<IMatterService, MatterService>();
            services.AddScoped<IUserService, UserService>();
            services.AddScoped<IWorkTypeService, WorkTypeService>();

            return services;
        }
    }
}