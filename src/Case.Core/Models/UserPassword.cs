namespace Case.Core.Models;

public class UserPassword
{
    public int Id { get; set; }
    public Guid UserId { get; set; }
    public byte[]? Hash { get; set; }
    
    public User User { get; set; }
}
