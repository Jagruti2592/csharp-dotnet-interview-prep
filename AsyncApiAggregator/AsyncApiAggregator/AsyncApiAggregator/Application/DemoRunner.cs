using AsyncApiAggregator.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AsyncApiAggregator.Application
{
    internal class DemoRunner
    {

        private readonly UserProfileAggregatorService aggregator;

        public DemoRunner(UserProfileAggregatorService aggregator)
        {
            this.aggregator = aggregator;
        }
        public async Task RunAsync()
        {
            //var userService = new Services.UserService();
            //var orderService = new Services.OrderService();
            //var recommendationService = new Services.RecommendationService();

            //var aggregator = new UserProfileAggregatorService(userService, orderService, recommendationService);

            //var profile = await aggregator.GetUserProfileAsync(1);
            //Console.WriteLine($"User: {profile.User.Name}");
            //Console.WriteLine("Orders:");
            //foreach (var order in profile.Orders)
            //{
            //    Console.WriteLine($"- {order.OrderId} (${order.Amount})");
            //}

            //Console.WriteLine("Recommendations:");
            //foreach (var rec in profile.Recommendations)
            //{
            //    Console.WriteLine($"- {rec.ProductName}");
            //}

            var profile = await aggregator.GetUserProfileAsync(1);
            Console.WriteLine($"User: {profile.User.Name}");
            Console.WriteLine("Orders:");
            Console.WriteLine("- " + string.Join("\n- ", profile.Orders.Select(o => $"{o.OrderId} (${o.Amount})")));
            Console.WriteLine("Recommendations:");
            Console.WriteLine("- " + string.Join("\n- ", profile.Recommendations.Select(r => r.ProductName)));
            Console.WriteLine("Demo completed.");
        }
    }
}
