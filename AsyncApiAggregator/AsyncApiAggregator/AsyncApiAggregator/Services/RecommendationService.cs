using AsyncApiAggregator.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AsyncApiAggregator.Services
{
    internal class RecommendationService
    {
        public async Task<List<Recommendation>> GetRecommendationsAsync(int userId)
        {
            Console.WriteLine("Fetching recommendations for user {0}...", userId);
            await Task.Delay(800); // Simulate network delay
            return new List<Recommendation>
            {
                new Recommendation { ProductName = "Product A" },
                new Recommendation { ProductName = "Product B" },
                new Recommendation { ProductName = "Product C" }
            };
        }
    }
}
