using Domain.Entities;
using Domain.Ports;

namespace HexagonalArchitectureDemo.Application.UseCases;

public class CreateUserUseCase
{
	private readonly IUserRepository _userRepository;

	public CreateUserUseCase(IUserRepository userRepository)
	{
		_userRepository = userRepository;

	}


	public async Task ExecuteAsync(string name)
	{
		var user = new User(name);
		await _userRepository.AddAsync(user);
	}
}
