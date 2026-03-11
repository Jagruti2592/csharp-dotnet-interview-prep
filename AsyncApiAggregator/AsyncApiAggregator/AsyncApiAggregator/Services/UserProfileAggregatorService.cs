using AsyncApiAggregator.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AsyncApiAggregator.Services
{
    internal class UserProfileAggregatorService
    {
        private readonly UserService _userService;
        private readonly OrderService _orderService;
        private readonly RecommendationService _recommendationService;

        public UserProfileAggregatorService(UserService userService, OrderService orderService, RecommendationService recommendationService)
        {
            _userService = userService;
            _orderService = orderService;
            _recommendationService = recommendationService;
        }

        public async Task<UserProfile> GetUserProfileAsync(int userId)
        {
            try
            {
                var userTask = _userService.GetUserAsync(userId);
                var ordersTask = _orderService.GetOrderAsync(userId);
                var recommendationsTask = _recommendationService.GetRecommendationsAsync(userId);


                await Task.WhenAll(userTask, ordersTask, recommendationsTask);

                return new UserProfile
                {
                    User = userTask.Result,
                    Orders = ordersTask.Result,
                    Recommendations = recommendationsTask.Result
                };

            }
            catch (Exception ex)
            {
                // Log the exception (not implemented here)
                throw new ApplicationException("An error occurred while aggregating user profile data.", ex);

            }
        }
    }
}
