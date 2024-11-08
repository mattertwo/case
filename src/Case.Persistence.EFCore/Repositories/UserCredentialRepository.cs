using Case.Core.Models;
using Case.Core.Repositories;
using Microsoft.EntityFrameworkCore;

namespace Case.Persistence.EFCore.Repositories;

public class UserCredentialRepository(CaseDbContext context) : IUserCredentialRepository
{
    public async Task<UserCredential?> GetCredentialAsync(string authType, string providerAccountId) =>
        await context.UserCredentials
            .FirstOrDefaultAsync(c => c.AuthType == authType && c.ProviderAccountId == providerAccountId);

    public async Task AddCredentialAsync(UserCredential credential)
    {
        context.UserCredentials.Add(credential);
        await context.SaveChangesAsync();
    }

    public async Task UpdateCredentialAsync(UserCredential credential)
    {
        context.UserCredentials.Update(credential);
        await context.SaveChangesAsync();
    }

    public async Task DisableCredentialAsync(int credentialId)
    {
        var credential = await context.UserCredentials.FindAsync(credentialId);
        if (credential != null)
        {
            credential.Enabled = false;
            await context.SaveChangesAsync();
        }
    }
}