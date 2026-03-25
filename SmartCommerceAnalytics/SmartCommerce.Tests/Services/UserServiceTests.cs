using Moq;
using SmartCommerce.Application.DTOs;
using SmartCommerce.Application.Exceptions;
using SmartCommerce.Application.Interfaces;
using SmartCommerce.Application.Services;
using SmartCommerce.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static NUnit.Framework.Constraints.Tolerance;

namespace SmartCommerce.Tests.Services
{
    public class UserServiceTests
    {
        private Mock<IUserRepository> _mockRepo;
        private UserService _userService;

        [SetUp]
        public void Setup() { 
        
         _mockRepo = new Mock<IUserRepository>();
         _userService = new UserService(_mockRepo.Object);

        }

        [Test]
        public async Task GetUserByIdAsync_ShouldReturnUser_WhenUserExists() {

            //Arrange
            var user = new User { Id = 1, Name = "John Doe", Email = "john@test.com" };

            _mockRepo.Setup(repo => repo.GetByIdAsync(1))
                .ReturnsAsync(user);

            //Act
            var result = await _userService.GetUserByIdAsync(1);

            //Assert
            Assert.Multiple(() =>
            {
                Assert.That(result.Id, Is.EqualTo(1));
                Assert.That(result.Name, Is.EqualTo("John Doe"));
                Assert.That(result.Email, Is.EqualTo("john@test.com"));

            });
        }

        [Test]
        public async Task GetAllUsersAsync_ShouldReturnAllUsers_WhenUsersExist()
        {
            // Arrange
            var usersFromRepo = new List<User>
    {
        new User { Id = 1, Name = "John Doe", Email = "john@test.com" },
        new User { Id = 2, Name = "Jim Helpart", Email = "jim@test.com" }
    };

            _mockRepo
                .Setup(r => r.GetAllAsync())
                .ReturnsAsync(usersFromRepo);

            var expected = new List<UserDto>
    {
        new UserDto(1, "John Doe", "john@test.com"),
        new UserDto(2, "Jim Helpart", "jim@test.com")
    };

            // Act
            var result = await _userService.GetAllUsersAsync();

            // Assert
            Assert.That(result, Is.EquivalentTo(expected));
        }

        [Test]
        public async Task CreateUserAsync_ShouldCreateNewUser_WhenUserDoesNotExists()
        {
            // Arrange
            var dto = new CreateUserDto
            {
                Name = "John Doe",
                Email = "john@test.com"
            };

            _mockRepo.Setup(repo => repo.AddAsync(It.IsAny<User>()))
                     .Returns(Task.CompletedTask);

            // Act
            var result = await _userService.CreateUserAsync(dto);

            // Assert
            //sert.NotNull(result);

            Assert.Multiple(() =>
            {
                Assert.That(result.Name, Is.EqualTo(dto.Name));
                Assert.That(result.Email, Is.EqualTo(dto.Email));
            });

            // 🔥 MOST IMPORTANT
            _mockRepo.Verify(repo => repo.AddAsync(It.Is<User>(u =>
                u.Name == dto.Name &&
                u.Email == dto.Email
            )), Times.Once);
        }

        [Test]
        public async Task UpdateUserAsync_ShouldUpdateUser_WhenUserExists()
        {
            // Arrange
            var dto = new UpdateUserDto
            {
                Id = 1,
                Name = "Updated Name",
                Email = "updated@test.com"
            };

            var existingUser = new User
            {
                Id = 1,
                Name = "Old Name",
                Email = "old@test.com"
            };

            _mockRepo.Setup(repo => repo.GetByIdAsync(dto.Id))
                     .ReturnsAsync(existingUser);

            _mockRepo.Setup(repo => repo.UpdateAsync(It.IsAny<User>()))
                     .Returns(Task.CompletedTask);

            // Act
            var result = await _userService.UpdateUserAsync(dto);

            // Assert
           //ssert.IsTrue(result);

            _mockRepo.Verify(repo => repo.UpdateAsync(It.Is<User>(u =>
                u.Id == dto.Id &&
                u.Name == dto.Name &&
                u.Email == dto.Email
            )), Times.Once);
        }

        [Test]
        public void UpdateUserAsync_ShouldThrowException_WhenUserNotFound()
        {
            // Arrange
            var dto = new UpdateUserDto
            {
                Id = 999,
                Name = "Test",
                Email = "test@test.com"
            };

            _mockRepo.Setup(repo => repo.GetByIdAsync(dto.Id))
                     .ReturnsAsync((User)null);

            // Act & Assert
            Assert.ThrowsAsync<NotFoundException>(async () =>
                await _userService.UpdateUserAsync(dto));
        }

        [Test]
        public async Task DeleteUserAsync_ShouldDeleteUser_WhenUserExists()
        {
            // Arrange
            int userId = 1;

            var user = new User
            {
                Id = userId,
                Name = "Test",
                Email = "test@test.com"
            };

            _mockRepo.Setup(repo => repo.GetByIdAsync(userId))
                     .ReturnsAsync(user);

            _mockRepo.Setup(repo => repo.DeleteAsync(userId))
                     .Returns(Task.CompletedTask);

            // Act
            var result = await _userService.DeleteUserAsync(userId);

            // Assert
            
            Assert.That(result, Is.True);
            

            _mockRepo.Verify(repo => repo.DeleteAsync(userId), Times.Once);
        }

        [Test]
        public void DeleteUserAsync_ShouldThrowException_WhenUserNotFound()
        {
            // Arrange
            int userId = 999;

            _mockRepo.Setup(repo => repo.GetByIdAsync(userId))
                     .ReturnsAsync((User)null);

            // Act & Assert
            Assert.ThrowsAsync<NotFoundException>(async () =>
                await _userService.DeleteUserAsync(userId));
        }
    }
}
