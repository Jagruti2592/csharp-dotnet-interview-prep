using EmployeeAnalyticSystem.DTOs;
using EmployeeAnalyticSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeAnalyticSystem.Services
{
    internal class EmployeeAnalyticsService
    {
        private readonly IEnumerable<Employee> employees;

        public EmployeeAnalyticsService(List<Employee> employees)
        {
            this.employees = employees;
        }

        public IEnumerable<Employee> GetHighSalaryEmployees(decimal threshold) { 
        
              return employees.Where( e => e.Salary > threshold);
        }

        public IEnumerable<Employee>GetEmployeesByDepartment(string department)
        {
            return employees.Where(e => e.Department == department);
        }

        public decimal GetAverageSalary()
        {
            return employees.Average(e => e.Salary);
        }

            public Employee GetMostExperiencedEmployee()
            {
                return employees.OrderByDescending(e => e.YearsOfExperience).FirstOrDefault();
        }


        public IEnumerable<IGrouping<string,Employee>> GroupEmployeesByDepartment()
        {
            return employees.GroupBy(e => e.Department);
        }

        public void PrintSalaryStatistics() {
            Console.WriteLine($"Total Employees: {employees.Count()}");
            Console.WriteLine($"Average Salary: {employees.Average(e => e.Salary)}");
            Console.WriteLine($"Highest Salary: {employees.Max(e => e.Salary)}");
            Console.WriteLine($"Lowest Salary: {employees.Min(e => e.Salary)}");

        }

        public IEnumerable<object> GetDepartmentSalaryStats() {
             
            return employees.GroupBy(e => e.Department)
                            .Select(g => new
                            {

                                Department = g.Key,
                                AverageSalary = g.Average(e => e.Salary),
                                EmployeeCount = g.Count()
                            });
        }

        public IEnumerable<Employee> EmployeeSalaryGreaterThan80k() {

            return employees.Where(e => e.Salary > 80000);
        }

        public List<string> GetEmployeesByName() { 
        
          return employees.Select(e => e.Name).ToList();
        }


        public IEnumerable<Employee> EmployeesSortedBySalary()
        {
            return employees.OrderByDescending(e => e.Salary);
        }

        public object FindEmployeeById(int id) {


            if (employees != null)
            {
                return employees.FirstOrDefault(e => e.Id == id);
            }
            else
            {
                return $"Employee with ID {id} not found.";
            }
        }


        public IEnumerable<Employee> GetTopPaidEmployees(int count) {
         
            return employees.OrderByDescending(e => e.Salary)
                            .Take(count);

        }
        //DTO mapping example, used commonly in APIs
        public IEnumerable<EmployeeSummaryDTO> GetEmployeeSummaries() {

            return employees.Select(e => new EmployeeSummaryDTO
            {
                Name = e.Name,
                Department = e.Department,
                Salary = e.Salary

            });
        }

        public IEnumerable<DepartmentSalaryStats> GetDepartmentSalaryStats1()
        {
            return employees
                .GroupBy(e => e.Department)
                .Select(g => new DepartmentSalaryStats
                {
                    Department = g.Key,
                    AverageSalary = g.Average(e => e.Salary),
                    MinSalary = g.Min(e => e.Salary),
                    MaxSalary = g.Max(e => e.Salary),
                    EmployeeCount = g.Count()
                });
        }
    }
}
