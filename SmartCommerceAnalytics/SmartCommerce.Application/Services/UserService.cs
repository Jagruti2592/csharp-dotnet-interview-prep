using SmartCommerce.Domain.Entities;
using SmartCommerce.Application.Interfaces;
using SmartCommerce.Application.Services;
using SmartCommerce.Application.DTOs;
using SmartCommerce.Application.Mappings;

namespace SmartCommerce.Application.Services {

    public class UserService : IUserService{ 
    
    
        private readonly IUserRepository _repository;

        public UserService(IUserRepository repository)
        {
            _repository = repository;

        }

        public async Task<List<UserDto>> GetAllUsersAsync()
        {
            var users = await _repository.GetAllAsync();
            return users.Select(UserMapping.ToDto).ToList();
        }

        public async Task<UserDto?> GetUserByIdAsync(int id)
        {
            var user= await _repository.GetByIdAsync(id);
            return user == null ? null : UserMapping.ToDto(user);
        }

        public async Task<UserDto> CreateUserAsync(CreateUserDto dto)
        {
            var user = UserMapping.ToEntity(dto);

            await _repository.AddAsync(user);

            return UserMapping.ToDto(user);
        }

        public async Task<bool> UpdateUserAsync(UpdateUserDto dto)
        {
            var existingUser = await _repository.GetByIdAsync(dto.Id);
            if (existingUser == null)
            {
                throw new Exception("User not found");
            }

            UserMapping.UpdateEntity(existingUser, dto);

            await _repository.UpdateAsync(existingUser);

            return true;
        }

        public async Task<bool> DeleteUserAsync(int id)
        {
            var existingUser = await _repository.GetByIdAsync(id);

            if (existingUser == null)
                return false;

            await _repository.DeleteAsync(id);

            return true;
        }
    }

}