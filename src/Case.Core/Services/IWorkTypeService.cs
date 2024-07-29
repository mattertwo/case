using Case.Infrastructure.Persistence.Entities;

namespace Case.Core.Services;

public interface IWorkTypeService
{
    Task<List<WorkType>> GetAllAsync();
}