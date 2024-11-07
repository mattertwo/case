using Microsoft.EntityFrameworkCore;

namespace Case.Persistence.EFCore;

public interface IDbProviderConfigurator
{
    void Configure(DbContextOptionsBuilder optionsBuilder, string connectionString);
}