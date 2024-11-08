using Case.Core.Models;
using Case.Core.Repositories;
using Microsoft.EntityFrameworkCore;

namespace Case.Persistence.EFCore.Repositories;

public class ClientRepository(CaseDbContext dbContext) : IClientRepository
{
    public Task<List<Client>> GetAllAsync()
    {
        return dbContext.Clients.ToListAsync();
    }
}