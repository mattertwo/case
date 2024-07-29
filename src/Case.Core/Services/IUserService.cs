using Case.Infrastructure.Persistence.Entities;

namespace Case.Core.Services;

public interface IUserService
{
    Task<List<User>> GetAllAsync();
}