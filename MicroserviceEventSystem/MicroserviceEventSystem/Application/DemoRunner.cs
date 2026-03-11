using MicroserviceEventSystem.Events;
using MicroserviceEventSystem.Models;
using MicroserviceEventSystem.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MicroserviceEventSystem.Application
{
    internal class DemoRunner
    {
         public void Run()
        {

            EventBus eventBus = new EventBus();

            OrderService orderService = new OrderService(eventBus);

            NotificationService notificationService = new NotificationService();
            InventoryService inventoryService = new InventoryService();
            ShippingService shippingService = new ShippingService();
            AnalyticsService analyticsService = new AnalyticsService();

            eventBus.OrderPlaced += notificationService.HandleOrderPlaced;
            eventBus.OrderPlaced += inventoryService.handleOrderPlaced;
            eventBus.OrderPlaced += shippingService.handleOrderPlaced;
            eventBus.OrderPlaced += analyticsService.HandleOrderPlaced;

            Order order = new Order
            {
                OrderId = 2001,
                CustomerEmail = "customer@email.com",
                Amount = 500
            };

            orderService.PlaceOrder(order);
        }

    }
}
