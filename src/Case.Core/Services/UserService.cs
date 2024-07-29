using Case.Infrastructure.Persistence;
using Case.Infrastructure.Persistence.Entities;
using Microsoft.EntityFrameworkCore;

namespace Case.Core.Services;

public class UserService(CaseDbContext dbContext) : IUserService
{
    public Task<List<User>> GetAllAsync()
    {
        return dbContext.Users.ToListAsync();
    }
}