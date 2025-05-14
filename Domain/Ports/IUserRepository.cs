using Domain.Entities;

namespace Domain.Ports;

public interface IUserRepository
{
	Task AddAsync(User user);
	Task<IEnumerable<User>> GetAllAsync();
	Task<User?> GetByIdAsync(Guid id);
}
