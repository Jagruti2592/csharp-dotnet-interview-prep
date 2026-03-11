using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AsyncApiAggregator.Models
{
    internal class UserProfile
    {
        public User User { get; set; }
        public List<Order> Orders { get; set; }
        public List<Recommendation> Recommendations { get; set; }
    }
}
