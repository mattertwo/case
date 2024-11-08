using Case.Core.Models;

namespace Case.Core.Repositories;

public interface IUserPasswordRepository
{
    Task<UserPassword?> GetPasswordByUserIdAsync(Guid userId);
    Task SetPasswordAsync(UserPassword password);
    Task UpdatePasswordAsync(UserPassword password);
}