using Case.Core.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Case.Persistence.EFCore.SqlServer.Configurations;

public class UserConfiguration : IEntityTypeConfiguration<User>
{
    public void Configure(EntityTypeBuilder<User> builder)
    {
        builder.HasKey(u => u.Id);

        builder
            .HasIndex(u => u.Email)
            .IsUnique();

        builder
            .Property(u => u.TimeZone)
            .HasDefaultValue("Europe/London");
        builder
            .Property(u => u.TwoFactorEnabled)
            .HasDefaultValue(false);
        builder
            .Property(u => u.CreatedAt)
            .HasDefaultValue(DateTime.UtcNow);

        builder
            .HasMany(u => u.Credentials)
            .WithOne(c => c.User)
            .HasForeignKey(c => c.UserId)
            .OnDelete(DeleteBehavior.Cascade);
        builder
            .HasOne(u => u.Password)
            .WithOne(p => p.User)
            .HasForeignKey<UserPassword>(p => p.UserId)
            .OnDelete(DeleteBehavior.Cascade);
    }
}