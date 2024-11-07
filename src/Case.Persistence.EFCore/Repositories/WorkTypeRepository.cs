using Case.Core.Models;
using Case.Core.Repositories;
using Microsoft.EntityFrameworkCore;

namespace Case.Persistence.EFCore.Repositories;

public class WorkTypeRepository(CaseDbContext dbContext) : IWorkTypeRepository
{
    public Task<List<WorkType>> GetAllAsync()
    {
        return dbContext.WorkTypes.ToListAsync();
    }
}