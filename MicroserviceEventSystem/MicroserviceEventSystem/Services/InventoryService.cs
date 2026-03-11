using MicroserviceEventSystem.Events;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MicroserviceEventSystem.Services
{
    internal class InventoryService
    {
        public void handleOrderPlaced(object sender, OrderPlacedEventArgs e)
        {             Console.WriteLine($"Inventory updated for order {e._Order.OrderId} with amount {e._Order.Amount}");
        }
    }
}
