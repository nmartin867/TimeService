using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Annotations;

namespace TimeService.Controllers;

// <snippet_ClassDeclaration>
[ApiController]
[Route("api/[controller]")]
[Produces("application/json")]
public class ClockController : ControllerBase
{
    [HttpGet("CalculateTimeAngle")]
    [SwaggerResponse(200, "The product was created", typeof(Product))]
    [SwaggerResponse(400, "The product data is invalid")]
    public IActionResult Get(
        [FromQuery, SwaggerParameter("ISO formated time")] TimeOnly time)
    {
        if (!ModelState.IsValid)
        {
            return BadRequest(ModelState);
        }
        return Ok(time);
    }
}