using Case.Core.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Case.Persistence.EFCore.PostgreSql.EntityTypeConfigurations;

public class WorkTypeEntityTypeConfiguration : IEntityTypeConfiguration<WorkType>
{
    public void Configure(EntityTypeBuilder<WorkType> builder)
    {
        builder.ToTable("work_types");
        
        builder
            .Property(e => e.Id)
            .HasColumnName("id")
            .IsRequired();
        builder
            .Property(e => e.Name)
            .HasColumnName("name")
            .IsRequired();
        
        builder.HasKey(e => e.Id);
    }
}