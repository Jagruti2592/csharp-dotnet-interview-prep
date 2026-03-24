using SmartCommerce.Application.DTOs;
using SmartCommerce.Domain.Entities;

namespace SmartCommerce.Application.Mappings
{
    public static class UserMapping
    {
        public static User ToEntity(CreateUserDto dto)
        {
            return new User
            {
                Name = dto.Name,
                Email = dto.Email,
            };
        }

        public static UserDto ToDto(User user)
        {
            return new UserDto(
                user.Id,
                user.Name,
                user.Email
            );
        }

        public static void UpdateEntity(User user, UpdateUserDto dto)
        {
            user.Name = dto.Name;
            user.Email = dto.Email;
        }
    }
}