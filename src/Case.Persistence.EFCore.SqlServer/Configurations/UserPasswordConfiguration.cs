using Case.Core.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Case.Persistence.EFCore.SqlServer.Configurations;

public class UserPasswordConfiguration : IEntityTypeConfiguration<UserPassword>
{
    public void Configure(EntityTypeBuilder<UserPassword> builder)
    {
        builder.HasKey(p => p.Id);

        // Configure one-to-one relationship with User
        builder.HasOne(p => p.User)
            .WithOne(u => u.Password)
            .HasForeignKey<UserPassword>(p => p.UserId)
            .OnDelete(DeleteBehavior.Cascade);

        // Password hash storage configuration
        builder.Property(p => p.Hash)
            .IsRequired()
            .HasMaxLength(64); // Example max length for a SHA-512 hash
    }
}