using Case.Core.Services;
using Microsoft.AspNetCore.Mvc;

namespace Case.WebApi.Controllers;

[ApiController]
[Route("matter")]
public class MatterController(IMatterService matterService) : ControllerBase
{
    [HttpGet]
    public async Task<IActionResult> Get()
    {
        var matters = await matterService.GetAllAsync();
        return Ok(matters);
    }
}