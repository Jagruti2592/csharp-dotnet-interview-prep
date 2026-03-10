using EmployeeAnalyticSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeAnalyticSystem.Services
{
    internal class ReportingService
    {
        public void PrintDepartmentSalaryReport(IEnumerable<DepartmentSalaryStats> stats)
        {
            Console.WriteLine("\nDepartment Slalry Report: ");

            foreach (var stat in stats)
            {
                Console.WriteLine($"Department: {stat.Department}");
                Console.WriteLine($"  Average Salary: {stat.AverageSalary:C}");
                Console.WriteLine($"  Min Salary: {stat.MinSalary:C}");
                Console.WriteLine($"  Max Salary: {stat.MaxSalary:C}");
                Console.WriteLine($"  Employee Count: {stat.EmployeeCount}");
                Console.WriteLine();
            }

        }
    }
}
