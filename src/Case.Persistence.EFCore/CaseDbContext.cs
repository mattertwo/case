using Case.Core.Models;
using Microsoft.EntityFrameworkCore;
using System.Reflection;

namespace Case.Persistence.EFCore;

public class CaseDbContext(DbContextOptions<CaseDbContext> options) : DbContext(options)
{
    public DbSet<Matter> Matters { get; set; }
    public DbSet<User> Users { get; set; }
    public DbSet<WorkType> WorkTypes { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetAssembly(typeof(CaseDbContext)) ??
                                                     Assembly.GetExecutingAssembly());
    }
}