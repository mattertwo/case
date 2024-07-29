using Case.Core.Services;
using Microsoft.AspNetCore.Mvc;

namespace Case.WebApi.Controllers;

[ApiController]
[Route("work-types")]
public class WorkTypeController(IWorkTypeService workTypeService) : ControllerBase
{
    [HttpGet]
    public async Task<IActionResult> Get()
    {
        var workTypes = await workTypeService.GetAllAsync();
        return Ok(workTypes);
    }
}