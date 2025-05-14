using Domain.Entities;
using Domain.Ports;

namespace HexagonalArchitectureDemo.Application.UseCases;

public class GetAllUsersUseCase
{
	private readonly IUserRepository _userRepository;

	public GetAllUsersUseCase(IUserRepository userRepository)
	{
		_userRepository = userRepository;
	}

	public async Task<IEnumerable<User>> ExecuteAsync()
	{
		return await _userRepository.GetAllAsync();
	}
}