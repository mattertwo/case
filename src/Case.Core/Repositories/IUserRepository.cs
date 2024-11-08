using Case.Core.Models;

namespace Case.Core.Repositories;

public interface IUserRepository
{
    Task<List<User>> GetAllAsync();
    Task<User> GetUserByIdAsync(string id);
    Task CreateUserAsync(User user);
}