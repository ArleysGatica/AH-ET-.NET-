public class Program
{
	public static void Main(string[] args)
	{
		var builder = WebApplication.CreateBuilder(args);

		// Add services to the container.
		builder.Services.AddControllers();
		builder.Services.AddEndpointsApiExplorer();
		builder.Services.AddSwaggerGen(); // Asegúrate de que Swagger está habilitado

		var app = builder.Build();

		// Configure the HTTP request pipeline.
		if (app.Environment.IsDevelopment())
		{
			app.UseSwagger(); // Habilita Swagger
			app.UseSwaggerUI(); // Habilita la interfaz de usuario de Swagger
		}

		app.UseHttpsRedirection();

		app.MapControllers();

		app.Run();
	}
}
