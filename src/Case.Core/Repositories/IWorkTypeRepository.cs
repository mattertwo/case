using Case.Core.Models;

namespace Case.Core.Repositories;

public interface IWorkTypeRepository
{
    Task<List<WorkType>> GetAllAsync();
}