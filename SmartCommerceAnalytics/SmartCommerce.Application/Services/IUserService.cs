using SmartCommerce.Domain.Entities;
using SmartCommerce.Application.DTOs;

namespace SmartCommerce.Application.Services
{
    public interface IUserService
    {
        Task<List<UserDto>> GetAllUsersAsync();
        Task<UserDto?> GetUserByIdAsync(int id);
        Task<UserDto> CreateUserAsync(CreateUserDto dto);
        Task<bool> UpdateUserAsync(UpdateUserDto dto);
        Task<bool> DeleteUserAsync(int id);
    }
}
