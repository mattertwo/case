using Case.Core.Models;
using Case.Core.Repositories;

namespace Case.Core.Services
{
    public class UserService(IUserRepository userRepository) : IUserService
    {
        public async Task<List<User>> GetAllAsync()
        {
            return await userRepository.GetAllAsync();
        }
    }
}