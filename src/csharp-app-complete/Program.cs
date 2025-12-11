using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using CSharpApp.Services;
using Microsoft.AspNetCore.Http;
using CSharpApp.Models;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddSingleton<IWeatherService, WeatherService>();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

app.UseSwagger();
app.UseSwaggerUI();

app.MapGet("/", (HttpContext http) => Results.Redirect("/swagger", permanent: false))
	.WithName("Root")
	.WithOpenApi(o => new(o) { Summary = "Redirect to Swagger UI", Description = "Redirects the root path to the Swagger UI for interactive API documentation." });

app.MapGet("/countries", (IWeatherService svc) => Results.Ok(svc.GetCountries()))
	.WithName("GetCountries")
	.WithTags("Weather")
	.Produces<IEnumerable<string>>(StatusCodes.Status200OK)
	.WithOpenApi(o => new(o) { Summary = "List countries", Description = "Returns the list of countries available in the weather dataset." });

app.MapGet("/countries/{country}/{city}/{month}", (string country, string city, string month, IWeatherService svc) =>
{
	if (svc.TryGetMonthlyAverage(country, city, month, out var dto))
	{
		return Results.Ok(dto);
	}
	return Results.NotFound();
})
	.WithName("GetMonthlyAverage")
	.WithTags("Weather")
	.Produces<TemperatureDto>(StatusCodes.Status200OK)
	.Produces(StatusCodes.Status404NotFound)
	.WithOpenApi(o => new(o) { Summary = "Get monthly temperature", Description = "Gets the high and low temperature for the given country, city and month." });

app.Run();
