using Case.Infrastructure.Persistence.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Case.Infrastructure.Persistence.EntityTypeConfigurations;

public class WorkTypeEntityTypeConfiguration : IEntityTypeConfiguration<WorkType>
{
    public void Configure(EntityTypeBuilder<WorkType> builder)
    {
    }
}