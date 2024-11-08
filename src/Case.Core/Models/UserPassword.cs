namespace Case.Core.Models;

public class UserPassword
{
    public int Id { get; set; }
    public User User { get; set; }
    public Guid UserId { get; set; } // Foreign key to User

    public byte[]? Hash { get; set; } // Password hash for security
}
