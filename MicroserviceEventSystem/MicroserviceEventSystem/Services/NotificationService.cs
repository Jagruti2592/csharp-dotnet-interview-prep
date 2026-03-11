using MicroserviceEventSystem.Events;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MicroserviceEventSystem.Services
{
    internal class NotificationService
    {
        public void HandleOrderPlaced(object sender, OrderPlacedEventArgs e)
        {
            Console.WriteLine($"Email sent to {e._Order.CustomerEmail} for order {e._Order.OrderId}"); 
        }
    }
}
