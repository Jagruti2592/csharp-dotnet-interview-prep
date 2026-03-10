using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeAnalyticSystem.DTOs
{
    //Instead of returning full Employee objects, we can return(APIs often return) a simplified version with only the necessary information for certain views or reports.
    internal class EmployeeSummaryDTO
    {
        public string Name { get; set; }
        public string Department { get; set; }
        public decimal Salary { get; set; }
    }
}
