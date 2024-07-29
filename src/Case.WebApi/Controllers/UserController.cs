using Case.Core.Services;
using Microsoft.AspNetCore.Mvc;

namespace Case.WebApi.Controllers;

[ApiController]
[Route("users")]
public class UserController(IUserService userService) : ControllerBase
{
    [HttpGet]
    public async Task<IActionResult> Get()
    {
        var users = await userService.GetAllAsync();
        return Ok(users);
    }
}