using Microsoft.Extensions.Hosting;
using Serilog;

namespace Case.Infrastructure.Extensions;

public static class HostBuilderExtensions
{
    public static IHostBuilder UseInfrastructureHostBuilders(this IHostBuilder builder)
    {
        builder.UseLogging();

        return builder;
    }

    private static IHostBuilder UseLogging(this IHostBuilder builder)
    {
        builder.UseSerilog((hostingContext, loggerConfiguration) =>
            loggerConfiguration.ReadFrom.Configuration(hostingContext.Configuration));

        return builder;
    }
}