using Case.Core.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Case.Persistence.EFCore.SqlServer.Configurations;

public class UserCredentialConfiguration : IEntityTypeConfiguration<UserCredential>
{
    public void Configure(EntityTypeBuilder<UserCredential> builder)
    {
        builder.HasKey(c => c.Id);
        
        builder
            .HasIndex(c => new { c.AuthType, c.ProviderAccountId })
            .IsUnique()
            .HasFilter("[ProviderAccountId] IS NOT NULL");
        
        builder
            .Property(c => c.AccessToken)
            .HasMaxLength(200);
        builder
            .Property(c => c.RefreshToken)
            .HasMaxLength(200);
        builder
            .Property(c => c.Enabled)
            .HasDefaultValue(true);
        
        builder
            .HasOne(c => c.User)
            .WithMany(u => u.Credentials)
            .HasForeignKey(c => c.UserId)
            .OnDelete(DeleteBehavior.Cascade);        
    }
}