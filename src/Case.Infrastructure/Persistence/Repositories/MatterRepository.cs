using Case.Infrastructure.Persistence;
using Case.Core.Models;
using Microsoft.EntityFrameworkCore;

namespace Case.Core.Services;

public class MatterRepository(CaseDbContext dbContext) : IMatterService
{
    public Task<List<Matter>> GetAllAsync()
    {
        return dbContext.Matters.ToListAsync();
    }
}