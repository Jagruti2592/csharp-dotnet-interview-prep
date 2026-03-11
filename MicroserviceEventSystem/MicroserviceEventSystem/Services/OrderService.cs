using MicroserviceEventSystem.Events;
using MicroserviceEventSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MicroserviceEventSystem.Services
{
    internal class OrderService
    {
        private readonly EventBus eventBus;

        public OrderService(EventBus eventBus)
        {
            this.eventBus = eventBus;
        }

        public void PlaceOrder(Order order)
        {
            Console.WriteLine($"Placing order {order.OrderId} for {order.CustomerEmail} with amount {order.Amount}");

            eventBus.PublishOrderPlaced(this, new OrderPlacedEventArgs(order));
        }
    }
}
