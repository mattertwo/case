using Case.Infrastructure.Persistence;
using Case.Infrastructure.Persistence.Entities;
using Microsoft.EntityFrameworkCore;

namespace Case.Core.Services;

public class MatterService(CaseDbContext dbContext) : IMatterService
{
    public Task<List<Matter>> GetAllAsync()
    {
        return dbContext.Matters.ToListAsync();
    }
}