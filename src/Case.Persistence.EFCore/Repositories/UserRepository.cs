using Case.Core.Models;
using Case.Core.Repositories;
using Microsoft.EntityFrameworkCore;

namespace Case.Persistence.EFCore.Repositories;

public class UserRepository(CaseDbContext context) : IUserRepository
{
    public async Task<User?> GetUserByIdAsync(Guid userId) =>
        await context.Users.FindAsync(userId);

    public async Task<User?> GetUserByEmailAsync(string email) =>
        await context.Users.FirstOrDefaultAsync(u => u.Email == email);

    public async Task<User?> GetUserWithCredentialsAsync(Guid userId) =>
        await context.Users
            .Include(u => u.Credentials)
            .FirstOrDefaultAsync(u => u.Id == userId);

    public async Task AddUserAsync(User user)
    {
        context.Users.Add(user);
        await context.SaveChangesAsync();
    }

    public async Task UpdateUserAsync(User user)
    {
        context.Users.Update(user);
        await context.SaveChangesAsync();
    }
}