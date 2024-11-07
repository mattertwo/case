using Case.Core.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Case.Persistence.EFCore.SqlServer.EntityTypeConfigurations;

public class MatterEntityTypeConfiguration : IEntityTypeConfiguration<Matter>
{
    public void Configure(EntityTypeBuilder<Matter> builder)
    {
        builder
            .Property(e => e.Id)
            .IsRequired();
        builder
            .Property(e => e.Name)
            .IsRequired();
        builder
            .Property(e => e.WorkTypeId)
            .IsRequired();
        builder
            .Property(e => e.Status)
            .IsRequired();
        builder
            .Property(e => e.Currency)
            .IsRequired();

        builder.HasKey(e => e.Id);
    }
}