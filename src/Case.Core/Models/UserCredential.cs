using Case.Core.Models;

public class UserCredential
{
    public int Id { get; set; }
    public User User { get; set; }
    public Guid UserId { get; set; } // Foreign key to User

    public string AuthType { get; set; } // e.g., "entra_id", "google", "facebook"
    public string? ProviderAccountId { get; set; } // Unique ID from the provider
    public string? ProviderEmail { get; set; } // Email associated with the provider

    public string? AccessToken { get; set; }
    public string? RefreshToken { get; set; }
    public DateTime? TokenExpiration { get; set; }
    public string? TokenType { get; set; }
    public string? Scope { get; set; }
    public string? SessionState { get; set; }
}