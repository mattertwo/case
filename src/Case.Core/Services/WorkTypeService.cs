using Case.Core.Models;
using Case.Core.Repositories;

namespace Case.Core.Services
{
    public class WorkTypeService(IWorkTypeRepository workTypeRepository) : IWorkTypeService
    {
        public async Task<List<WorkType>> GetAllAsync()
        {
            return await workTypeRepository.GetAllAsync();
        }
    }
}