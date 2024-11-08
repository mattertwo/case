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
    
    public async Task<User> GetUserByIdAsync(string id)
    {
        return await dbContext.Users.FindAsync(id);
    }

    public async Task CreateUserAsync(User user)
    {
        dbContext.Users.Add(user);
        await dbContext.SaveChangesAsync();
    }
}