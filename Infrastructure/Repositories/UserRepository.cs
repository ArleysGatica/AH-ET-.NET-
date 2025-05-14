using Domain.Entities;
using Domain.Ports;
using Infrastructure.Persistence;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Repositories;

public class UserRepository : IUserRepository
{
	private readonly UserDbContext _context;

	public UserRepository(UserDbContext context)
	{
		_context = context;
	}

	public async Task AddAsync(User user)
	{
		_context.Users.Add(user);
		await _context.SaveChangesAsync();
	}

	public async Task<IEnumerable<User>> GetAllAsync()
	{
		return await _context.Users.ToListAsync();
	}

	public async Task<User?> GetByIdAsync(Guid id)
	{
		return await _context.Users.FirstOrDefaultAsync(u => u.Id == id);
	}
}
