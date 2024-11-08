using Case.Core.Models;

namespace Case.Core.Repositories;

public interface IClientRepository
{
    Task<List<Client>> GetAllAsync();
}