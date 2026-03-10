using EmployeeAnalyticSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeAnalyticSystem.Data
{
    internal class EmployeeRepository
    {
        public List<Employee> GetEmployees()
        {
            return new List<Employee> { 
                
                new Employee{Id = 1, Name = "Alice", Department = "Engineering", Salary = 90000, YearsOfExperience = 6 },
                new Employee { Id = 2, Name = "Bob", Department = "Engineering", Salary = 75000, YearsOfExperience = 4 },
                new Employee { Id = 3, Name = "Charlie", Department = "HR", Salary = 65000, YearsOfExperience = 5 },
                new Employee { Id = 4, Name = "David", Department = "Finance", Salary = 80000, YearsOfExperience = 7 },
                new Employee { Id = 5, Name = "Eva", Department = "Engineering", Salary = 120000, YearsOfExperience = 10 }


                };
        }
    }
}
