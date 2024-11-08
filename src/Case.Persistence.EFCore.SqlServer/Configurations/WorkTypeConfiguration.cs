using Case.Core.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Case.Persistence.EFCore.SqlServer.Configurations;

public class WorkTypeConfiguration : IEntityTypeConfiguration<WorkType>
{
    public void Configure(EntityTypeBuilder<WorkType> builder)
    {
        builder
            .Property(e => e.Id)
            .IsRequired();
        builder
            .Property(e => e.Name)
            .IsRequired();
        
        builder.HasKey(e => e.Id);
    }
}