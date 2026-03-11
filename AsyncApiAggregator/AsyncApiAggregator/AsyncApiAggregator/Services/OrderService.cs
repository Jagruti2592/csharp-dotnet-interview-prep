using AsyncApiAggregator.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AsyncApiAggregator.Services
{
    internal class OrderService
    {
        public async Task<List<Order>> GetOrderAsync(int userId) { 
           
            Console.WriteLine("Fetching orders for user {0}...", userId);

            await Task.Delay(1200);

            return new List<Order>
            {
                new Order{ OrderId = 1, Amount = 100.50m },
                new Order { OrderId = 2, Amount = 250.00m },
                new Order { OrderId = 3, Amount = 75.25m }
            };
        }
    }
}
