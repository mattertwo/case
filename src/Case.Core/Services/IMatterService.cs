using Case.Core.Models;

namespace Case.Core.Services;

public interface IMatterService
{
    Task<List<Matter>> GetAllAsync();
}