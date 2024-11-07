using Microsoft.EntityFrameworkCore;

namespace Case.Persistence.EFCore.PostgreSql;

public class PostgreSqlDbProviderConfigurator : IDbProviderConfigurator
{
    public void Configure(DbContextOptionsBuilder optionsBuilder, string connectionString)
    {
        optionsBuilder.UseNpgsql(connectionString);
    }
}