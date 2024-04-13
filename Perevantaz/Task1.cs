using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Perevantaz
{
    internal class Task1
    {
        public class Employee
        {
            public string Name { get; set; }
            public string Position { get; set; }

            public decimal Salary { get; set; }

            public Employee(string name, string position, decimal salary)
            {
                Name = name;
                Position = position;
                Salary = salary;
            }

            public void IncreaseSalary(decimal amount)
            {
                Salary += amount;
            }

            public void DecreaseSalary(decimal amount)
            {
                Salary -= amount;
            }

            public bool SalaryEquals(Employee other)
            {
                return this.Salary == other.Salary;
            }

            public bool IsSalaryGreaterThan(Employee other)
            {
                return this.Salary > other.Salary;
            }

            public bool IsSalaryLessThan(Employee other)
            {
                return this.Salary < other.Salary;
            }

            public bool IsNotEquals(Employee other)
            {
                return this.Salary != other.Salary;
            }
        }
    }
}
