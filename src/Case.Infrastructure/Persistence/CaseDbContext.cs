using System.Reflection;
using Case.Infrastructure.Persistence.Entities;
using Microsoft.EntityFrameworkCore;

namespace Case.Infrastructure.Persistence;

public class CaseDbContext(DbContextOptions<CaseDbContext> options) : DbContext(options)
{
    public DbSet<Matter> Matters { get; set; }
    public DbSet<User> Users { get; set; }
    public DbSet<WorkType> WorkTypes { get; set; }
    
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
    }
}