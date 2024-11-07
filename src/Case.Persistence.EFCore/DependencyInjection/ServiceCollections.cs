using Microsoft.EntityFrameworkCore;

namespace Case.Persistence.EFCore.DependencyInjection;

public static class ServiceCollections
{
    public static void UseDbProvider(this DbContextOptionsBuilder optionsBuilder, string providerName, string connectionString)
    {
        switch (providerName)
        {
            case "SqlServer":
                optionsBuilder.UseSqlServer(connectionString);
                break;
            case "Sqlite":
                optionsBuilder.UseSqlite(connectionString);
                break;
            case "PostgreSql":
                optionsBuilder.UseNpgsql(connectionString)
                break;
            default:
                throw new InvalidDataException($"The provider {providerName} is not supported.");
        }
    }
}