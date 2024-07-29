using Case.Infrastructure.Persistence;
using Case.Infrastructure.Persistence.Entities;
using Microsoft.EntityFrameworkCore;

namespace Case.Core.Services;

public class WorkTypeService(CaseDbContext dbContext) : IWorkTypeService
{
    public Task<List<WorkType>> GetAllAsync()
    {
        return dbContext.WorkTypes.ToListAsync();
    }
}