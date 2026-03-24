using SmartCommerce.Domain.Entities;

namespace SmartCommerce.Application.Interfaces
{
    public interface IUserRepository
    {
        Task<List<User>> GetAllAsync();
        Task<User?> GetByIdAsync(int id);
        Task AddAsync(User user);
        Task UpdateAsync(User user);
        Task  DeleteAsync(int id);
    }
}