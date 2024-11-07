using Case.Core.Models;
using Case.Core.Repositories;

namespace Case.Core.Services
{
    public class MatterService(IMatterRepository matterRepository) : IMatterService
    {
        public async Task<List<Matter>> GetAllAsync()
        {
            return await matterRepository.GetAllAsync();
        }
    }
}