using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MicroserviceEventSystem.Models
{
    internal class Order
    {
        public int OrderId { get; set; }
        public string? CustomerEmail { get; set; }
        public decimal Amount { get; set; }
    }
}
