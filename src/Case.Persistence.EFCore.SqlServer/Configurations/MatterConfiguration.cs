using Case.Core.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Case.Persistence.EFCore.SqlServer.Configurations;

public class MatterConfiguration : IEntityTypeConfiguration<Matter>
{
    public void Configure(EntityTypeBuilder<Matter> builder)
    {
        builder.HasKey(m => new { m.ClientReference, m.MatterNumber });
        
        builder
            .Property(m => m.Status)
            .HasMaxLength(50);
        builder
            .Property(m => m.Currency)
            .HasMaxLength(3);
        builder
            .Property(m => m.Currency)
            .HasDefaultValue("GBP");
        
        builder.HasOne(m => m.Client)
            .WithMany(c => c.Matters)
            .HasForeignKey(m => m.ClientReference)
            .OnDelete(DeleteBehavior.Cascade);
        

    }
}