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
        
        public async Task<User> GetUserByIdAsync(string id)
        {
            return await userRepository.GetUserByIdAsync(id);
        }

        public async Task CreateUserAsync(User user)
        {
            await userRepository.CreateUserAsync(user);
        }
    }
}