using Microsoft.AspNetCore.Mvc;
using WebApiEnums.Models;

namespace WebApiEnums.Controllers;

[ApiController]
[Route("[controller]")]
public class FamilyController : ControllerBase
{
    private readonly ILogger<FamilyController> _logger;

    public FamilyController(ILogger<FamilyController> logger)
    {
        _logger = logger;
    }

    [HttpPost(Name = "Post")]
    public async Task<IActionResult> Post(FamilyRequest request)
    {
        await Task.Delay(0);
        return Ok(DateTime.UtcNow);
    }
}