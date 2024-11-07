using Case.Core.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Case.Persistence.EFCore.PostgreSql.EntityTypeConfigurations;

public class MatterEntityTypeConfiguration : IEntityTypeConfiguration<Matter>
{
    public void Configure(EntityTypeBuilder<Matter> builder)
    {
        builder.ToTable("matters");
        
        builder
            .Property(e => e.Id)
            .HasColumnName("id")
            .IsRequired();
        builder
            .Property(e => e.Name)
            .HasColumnName("name")
            .IsRequired();
        builder
            .Property(e => e.WorkTypeId)
            .HasColumnName("work_type_id")
            .IsRequired();
        builder
            .Property(e => e.Status)
            .HasColumnName("status")
            .IsRequired();
        builder
            .Property(e => e.Currency)
            .HasColumnName("currency")
            .IsRequired();

        builder.HasKey(e => e.Id);
    }
}