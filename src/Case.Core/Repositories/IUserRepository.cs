using Case.Core.Models;

namespace Case.Core.Repositories;

public interface IUserRepository
{
    Task<User?> GetUserByIdAsync(Guid userId);
    Task<User?> GetUserByEmailAsync(string email);
    Task<User?> GetUserWithCredentialsAsync(Guid userId);
    Task AddUserAsync(User user);
    Task UpdateUserAsync(User user);
}