using BackEndAPI.Implementations;
using BackEndAPI.Interfaces;
using BackEndAPI.POCO;
using Microsoft.AspNetCore.Mvc;

namespace BackEndAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private static readonly string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        private readonly ILogger<WeatherForecastController> _logger;
        private readonly IMathOperations _mathOperations;

        public WeatherForecastController(
            ILogger<WeatherForecastController> logger,
            IMathOperations mathOperations)
        {
            _logger = logger;
            _mathOperations = mathOperations;
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

        [HttpGet("math")]
        public ActionResult<MathResult> GetMathResult([FromQuery] double a, [FromQuery] double b)
        {
            var result = new MathResult
            {
                Add = _mathOperations.Add(a, b),
                Subtract = _mathOperations.Subtract(a, b),
                Multiply = _mathOperations.Multiply(a, b),
                Divide = _mathOperations.Divide(a, b)
            };
            return Ok(result);
        }
    }
}
