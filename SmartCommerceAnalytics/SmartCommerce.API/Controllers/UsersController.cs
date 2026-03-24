using Microsoft.AspNetCore.Mvc;
using SmartCommerce.Application.Services;
using SmartCommerce.Domain.Entities;
using SmartCommerce.Application.DTOs;

namespace SmartCommerce.API.Controllers;

[ApiController]
[Route("api/[controller]")]
public class UsersController : ControllerBase
{
    private readonly IUserService _service;

    public UsersController(IUserService service)
    {
        _service = service;
    }

    [HttpGet]
    public async Task<IActionResult> GetAll()
    {
        var users = await _service.GetAllUsersAsync();
        return Ok(users);
    }

    [HttpGet("{id}")]
    public async Task<IActionResult> GetById(int id)
    {
        var user = await _service.GetUserByIdAsync(id);
        if(user == null)
        {
            return NotFound();
        }
        return Ok(user);
    }

    [HttpPost]
    public async Task<IActionResult> Create([FromBody] CreateUserDto dto)
    {
        var user = await _service.CreateUserAsync(dto);

        return Ok(user);
    }

    [HttpPut("{id}")]
    public async Task<IActionResult> Update([FromBody] UpdateUserDto dto)
    {
        var result = await _service.UpdateUserAsync(dto);

        if (!result) return NotFound();

        return NoContent();
    }

    [HttpDelete("{id}")]
    public async Task<IActionResult> Delete(int id)
    {
        var result = await _service.DeleteUserAsync(id);

        if (!result)
            return NotFound();

        return NoContent();
    }

}