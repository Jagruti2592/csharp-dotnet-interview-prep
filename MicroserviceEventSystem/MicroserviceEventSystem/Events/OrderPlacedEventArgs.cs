using MicroserviceEventSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MicroserviceEventSystem.Events
{
    internal class OrderPlacedEventArgs : EventArgs
    {
        public Order _Order { get; }

        public OrderPlacedEventArgs(Order order) {
        
            this._Order = order;
        }
    }
}
