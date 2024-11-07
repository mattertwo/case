using Case.Infrastructure.Persistence;
using Case.Core.Models;
using Microsoft.EntityFrameworkCore;

namespace Case.Core.Services;

public class WorkTypeRepository(CaseDbContext dbContext) : IWorkTypeService
{
    public Task<List<WorkType>> GetAllAsync()
    {
        return dbContext.WorkTypes.ToListAsync();
    }
}