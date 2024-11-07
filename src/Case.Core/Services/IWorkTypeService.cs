using Case.Core.Models;

namespace Case.Core.Services;

public interface IWorkTypeService
{
    Task<List<WorkType>> GetAllAsync();
}