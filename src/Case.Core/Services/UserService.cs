using Case.Core.Models;
using Case.Core.Repositories;

namespace Case.Core.Services
{
    public class UserService(IUserRepository userRepository) : IUserService
    {
        public async Task<List<User>> GetAllAsync()
        {
            return new List<User>();
        }
        
        public async Task<User> GetUserByIdAsync(string id)
        {
            return new User();
        }

        public async Task CreateUserAsync(User user)
        {
        }
    }
}