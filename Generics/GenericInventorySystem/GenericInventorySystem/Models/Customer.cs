using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericInventorySystem.Models
{
    internal class Customer:IEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public String Email { get; set; }
    }
}
