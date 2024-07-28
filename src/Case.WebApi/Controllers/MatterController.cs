using Microsoft.AspNetCore.Mvc;

namespace Case.WebApi.Controllers;

[ApiController]
[Route("matter")]
public class MatterController : ControllerBase
{
    [HttpGet]
    public IActionResult Get()
    {
        return Ok();
    }
}