using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeAnalyticSystem.Models
{
    internal class DepartmentSalaryStats
    {
        public string Department { get; set; }
        public decimal AverageSalary { get; set; }
        public decimal MinSalary { get; set; }
        public decimal MaxSalary { get; set; }

        public int EmployeeCount { get; set; }
    }
}
