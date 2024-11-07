using Case.Core.Models;

namespace Case.Core.Services;

public interface IUserService
{
    Task<List<User>> GetAllAsync();
}