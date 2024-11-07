using Case.Core.Models;
using Case.Core.Repositories;
using Microsoft.EntityFrameworkCore;

namespace Case.Persistence.EFCore.Repositories;

public class MatterRepository(CaseDbContext dbContext) : IMatterRepository
{
    public Task<List<Matter>> GetAllAsync()
    {
        return dbContext.Matters.ToListAsync();
    }
}