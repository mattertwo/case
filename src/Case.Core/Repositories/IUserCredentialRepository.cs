using Case.Core.Models;

namespace Case.Core.Repositories;

public interface IUserCredentialRepository
{
    Task<UserCredential?> GetCredentialAsync(string authType, string providerAccountId);
    Task AddCredentialAsync(UserCredential credential);
    Task UpdateCredentialAsync(UserCredential credential);
    Task DisableCredentialAsync(int credentialId);
}