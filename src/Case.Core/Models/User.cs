namespace Case.Core.Models;

public class User
{
    public Guid Id { get; set; }
    public string? Name { get; set; }
    public string? Email { get; set; }
    public string? TimeZone { get; set; }
    public string? Locale { get; set; }
    public string? TwoFactorSecret { get; set; }
    public bool TwoFactorEnabled { get; set; }
    public DateTime CreatedAt { get; set; }
    
    public UserPassword? Password { get; set; }
    public ICollection<UserCredential> Credentials { get; set; } = new List<UserCredential>();
}