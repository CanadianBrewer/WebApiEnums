using Microsoft.AspNetCore.Mvc;
using WebApiEnums.Models;

namespace WebApiEnums.Controllers;

[ApiController]
[Route("[controller]")]
public class WeatherForecastController : ControllerBase
{
    private readonly ILogger<WeatherForecastController> _logger;

    public WeatherForecastController(ILogger<WeatherForecastController> logger)
    {
        _logger = logger;
    }

    [HttpGet(Name = "Get")]
    public async Task<IActionResult> Get(FamilyRequest request)
    {
        await Task.Delay(0);
        return Ok();
    }
}