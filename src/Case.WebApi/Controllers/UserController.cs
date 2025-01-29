using Case.Core.Services;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;
using Case.Core.Models;
using Microsoft.AspNetCore.Authorization;

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