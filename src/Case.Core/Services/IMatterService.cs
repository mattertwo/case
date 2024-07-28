using Case.Infrastructure.Persistence.Entities;

namespace Case.Core.Services;

public interface IMatterService
{
    Task<List<Matter>> GetAllAsync();
}