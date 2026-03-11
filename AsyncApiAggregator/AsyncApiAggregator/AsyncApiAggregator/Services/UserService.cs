using AsyncApiAggregator.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AsyncApiAggregator.Services
{
    internal class UserService
    {
        public async Task<User> GetUserAsync(int userId) {

            Console.WriteLine("Fetching user data...");

            // Simulate an asynchronous API call with Task.Delay
            await Task.Delay(1000); // Simulate network delay

            return new User
            {
                Id = userId,
                Name = "Jagruti"
            };
        }
    }
}
