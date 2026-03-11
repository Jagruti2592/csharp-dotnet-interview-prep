using MicroserviceEventSystem.Events;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MicroserviceEventSystem.Services
{
    internal class ShippingService
    {
        public void handleOrderPlaced(object sender, OrderPlacedEventArgs e) { 
          Console.WriteLine($"Shipping label created for order {e._Order.OrderId} to be shipped to {e._Order.CustomerEmail}");

        }
    }
}
