using Microsoft.EntityFrameworkCore;

namespace Case.Persistence.EFCore.SqlServer;

public class SqlServerDbProviderConfigurator : IDbProviderConfigurator
{
    public void Configure(DbContextOptionsBuilder optionsBuilder, string connectionString)
    {
        optionsBuilder.UseSqlServer(connectionString);
    }
}