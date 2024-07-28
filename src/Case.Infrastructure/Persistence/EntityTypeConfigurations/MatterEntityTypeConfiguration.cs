using Case.Infrastructure.Persistence.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Case.Infrastructure.Persistence.EntityTypeConfigurations;

public class MatterEntityTypeConfiguration : IEntityTypeConfiguration<Matter>
{
    public void Configure(EntityTypeBuilder<Matter> builder)
    {
    }
}