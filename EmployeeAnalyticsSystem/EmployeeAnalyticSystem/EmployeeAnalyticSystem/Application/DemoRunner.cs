using EmployeeAnalyticSystem.Data;
using EmployeeAnalyticSystem.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeAnalyticSystem.Application
{
    internal class DemoRunner
    {

        public void Run() {

            EmployeeRepository repository = new EmployeeRepository();

            var employees = repository.GetEmployees();

            EmployeeAnalyticsService analytics = new EmployeeAnalyticsService(employees);
            ReportingService reporting = new ReportingService();

            Console.WriteLine("High Salary Employees:");

            var highSalary = analytics.GetHighSalaryEmployees(80000);

            foreach (var emp in highSalary)
            {
                Console.WriteLine($"{emp.Name} - {emp.Salary}");
            }

            Console.WriteLine("Average Salary: " + analytics.GetAverageSalary());
            Console.WriteLine("Most Experienced Employee: " + analytics.GetMostExperiencedEmployee().Name);
             Console.WriteLine("Employees by Department:");

            var groups = analytics.GroupEmployeesByDepartment();

            foreach (var group in groups)
            {
                Console.WriteLine($"Department: {group.Key}");
                foreach (var emp in group)
                {
                    Console.WriteLine($" - {emp.Name}");
                }
            }

            var salaryStats = analytics.EmployeeSalaryGreaterThan80k();
                Console.WriteLine("Employees with Salary Greater than 80k:");
            foreach (var emp in salaryStats)
            {
                Console.WriteLine($" {emp.Name} - {emp.Salary}");
            }
            

            Console.WriteLine("Employees by Name: ", analytics.GetEmployeesByName());
            Console.WriteLine("Department Salary Stats: ", analytics.GetDepartmentSalaryStats());
            Console.WriteLine("Salary Statistics: ", analytics.EmployeesSortedBySalary());

            Console.WriteLine("Top Paid Employees:");

            var topEmployees = analytics.GetTopPaidEmployees(3);

            foreach (var emp in topEmployees)
            {
                Console.WriteLine($"{emp.Name} - {emp.Salary}");
            }

            var stats = analytics.GetDepartmentSalaryStats1();

            reporting.PrintDepartmentSalaryReport(stats);
        }
    }
}
