using Case.Core.Models;
using Case.Core.Repositories;
using Microsoft.EntityFrameworkCore;

namespace Case.Persistence.EFCore.Repositories;

public class UserRepository(CaseDbContext dbContext) : IUserRepository
{
    public Task<List<User>> GetAllAsync()
    {
        return dbContext.Users.ToListAsync();
    }
}