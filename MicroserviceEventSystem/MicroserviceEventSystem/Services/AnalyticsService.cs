using MicroserviceEventSystem.Events;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MicroserviceEventSystem.Services
{
    internal class AnalyticsService
    {
        public void HandleOrderPlaced(object sender, OrderPlacedEventArgs e)
        {
            Console.WriteLine($"Analytics recorded for order {e._Order.OrderId}");
        }
    }
}
