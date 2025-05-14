using Microsoft.AspNetCore.Mvc;
using HexagonalArchitectureDemo.Application.UseCases;

namespace HexagonalArchitectureDemo.API.Controllers;

[ApiController]
[Route("api/[controller]")]
public class UsersController : ControllerBase
{
    private readonly CreateUserUseCase _createUserUseCase;
    private readonly GetAllUsersUseCase _getAllUsersUseCase;

    public UsersController(
        CreateUserUseCase createUserUseCase,
        GetAllUsersUseCase getAllUsersUseCase)
    {
        _createUserUseCase = createUserUseCase;
        _getAllUsersUseCase = getAllUsersUseCase;
    }

    [HttpPost]
    public async Task<IActionResult> Create([FromBody] string name)
    {
        await _createUserUseCase.ExecuteAsync(name);
        return Ok("User created successfully.");
    }

    [HttpGet]
    public async Task<IActionResult> GetAll()
    {
        var users = await _getAllUsersUseCase.ExecuteAsync();
        return Ok(users);
    }
}