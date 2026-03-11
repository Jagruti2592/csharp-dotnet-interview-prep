using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MicroserviceEventSystem.Events
{
    internal class EventBus
    {
        public event EventHandler<OrderPlacedEventArgs> OrderPlaced;

        public void PublishOrderPlaced(object sender, OrderPlacedEventArgs args) {
        
         OrderPlaced?.Invoke(sender, args);
        
        }
    }
}
