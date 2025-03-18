using Microsoft.AspNetCore.Mvc;

namespace TimeService.Controllers;

[ApiController]
[Route("[controller]")]
public class ClockController : ControllerBase
{
    [HttpGet(Name = "CalculateTimeAngle")]
    public IActionResult Get([FromQuery] TimeOnly time)
    {
        if (!ModelState.IsValid)
        {
            return BadRequest(ModelState);
        }
        return Ok(time);
    }
}