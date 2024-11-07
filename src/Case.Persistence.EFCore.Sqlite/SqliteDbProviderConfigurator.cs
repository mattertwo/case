using Microsoft.EntityFrameworkCore;

namespace Case.Persistence.EFCore.Sqlite;

public class SqliteDbProviderConfigurator : IDbProviderConfigurator
{
    public void Configure(DbContextOptionsBuilder optionsBuilder, string connectionString)
    {
        optionsBuilder.UseSqlite(connectionString);
    }
}