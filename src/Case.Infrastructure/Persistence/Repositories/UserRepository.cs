using Case.Infrastructure.Persistence;
using Case.Core.Models;
using Microsoft.EntityFrameworkCore;

namespace Case.Core.Services;

public class UserRepository(CaseDbContext dbContext) : IUserService
{
    public Task<List<User>> GetAllAsync()
    {
        return dbContext.Users.ToListAsync();
    }
}