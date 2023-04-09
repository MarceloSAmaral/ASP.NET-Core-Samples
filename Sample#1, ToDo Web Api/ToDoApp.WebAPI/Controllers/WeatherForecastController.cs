using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;

namespace ToDoApp.WebAPI.Controllers;

[ApiController]
[Route("[controller]")]
public class WeatherForecastController : ControllerBase
{
    private static readonly string[] Summaries = new[] {"Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"};
    private readonly IHttpContextAccessor _httpContextAccessor;
    private readonly ILogger<WeatherForecastController> _logger;

    public WeatherForecastController(IHttpContextAccessor httpContextAccessor, ILogger<WeatherForecastController> logger)
    {
        _httpContextAccessor = httpContextAccessor;
        _logger = logger;
    }


    [HttpGet(Name = "GetWeatherForecast")]
    public IEnumerable<WeatherForecast> Get()
    {
        return Enumerable.Range(1, 5).Select(index => new WeatherForecast
        {
            Date = DateOnly.FromDateTime(DateTime.Now.AddDays(index)),
            TemperatureC = Random.Shared.Next(-20, 55),
            Summary = Summaries[Random.Shared.Next(Summaries.Length)]
        })
        .ToArray();
    }
}