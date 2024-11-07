using Case.Core.Models;

namespace Case.Core.Repositories;

public interface IMatterRepository
{
    Task<List<Matter>> GetAllAsync();
}