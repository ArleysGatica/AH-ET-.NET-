namespace Domain.Entities;

public class User(string name)
{
	public string Name { get; set; } = name;
	public Guid Id { get; set; } = Guid.NewGuid();
	public string Email { get; set; } = string.Empty;
}
