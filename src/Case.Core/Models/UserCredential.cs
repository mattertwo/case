namespace Case.Core.Models;

public class UserCredential
{
    public int Id { get; set; }
    public Guid UserId { get; set; }
    public string AuthType { get; set; }
    public string? ProviderAccountId { get; set; }
    public string? ProviderEmail { get; set; }
    public string? AccessToken { get; set; }
    public string? RefreshToken { get; set; }
    public DateTime? TokenExpiration { get; set; }
    public string? TokenType { get; set; }
    public string? Scope { get; set; }
    public string? SessionState { get; set; }
    
    public User User { get; set; }
}