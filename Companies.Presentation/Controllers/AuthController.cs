﻿using Companies.Shared.DTOs;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Services.Contracts;

namespace Companies.Presentation.Controllers;

[Route("api/[controller]")]
[ApiController]
public class AuthController : ControllerBase
{
    private readonly IServiceManager serviceManager;

    public AuthController(IServiceManager serviceManager)
    {
        this.serviceManager = serviceManager;
    }

    [HttpPost]
    public async Task<IActionResult> RegisterUser(UserForRegistrationDto registrationDto)
    {
        var result = await serviceManager.AuthService.RegisterUserAsync(registrationDto);
        return result.Succeeded ? StatusCode(StatusCodes.Status201Created) : BadRequest(result.Errors);
    }


    [HttpPost("login")]
    public async Task<IActionResult> Authenticate(UserForAuthDto userForAuthDto)
    {
        if (!await serviceManager.AuthService.ValidateUserAsync(userForAuthDto))
        {
            return Unauthorized();
        }

        var token = new { Token = await serviceManager.AuthService.CreateTokenAsync() };
        return Ok(token);
    }
}
