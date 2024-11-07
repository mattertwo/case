using Case.Core.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Case.Persistence.EFCore.PostgreSql.EntityTypeConfigurations;

public class UserEntityTypeConfiguration : IEntityTypeConfiguration<User>
{
    public void Configure(EntityTypeBuilder<User> builder)
    {
        builder.ToTable("users");
        
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