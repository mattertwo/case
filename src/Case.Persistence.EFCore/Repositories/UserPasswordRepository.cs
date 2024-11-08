using Case.Core.Models;
using Case.Core.Repositories;
using Microsoft.EntityFrameworkCore;

namespace Case.Persistence.EFCore.Repositories;

public class UserPasswordRepository(CaseDbContext context) : IUserPasswordRepository
{
    public async Task<UserPassword?> GetPasswordByUserIdAsync(Guid userId)
    {
        return await context.UserPasswords.FirstOrDefaultAsync(p => p.UserId == userId);
    }

    public async Task SetPasswordAsync(UserPassword password)
    {
        context.UserPasswords.Add(password);
        await context.SaveChangesAsync();
    }

    public async Task UpdatePasswordAsync(UserPassword password)
    {
        context.UserPasswords.Update(password);
        await context.SaveChangesAsync();
    }
}