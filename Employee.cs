using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADS103_Grishma_A00177960_Assignment3
{
    // Abstract base class for all types of employees
    abstract class Employee
    {
        protected string name;     // Name of the employee
        protected int salary;      // Base salary

        public Employee(string name, int salary)
        {
            this.name = name;
            this.salary = salary;
        }

        // Return the employee's salary
        public int GetSalary() => salary;

        // Abstract method for printing earnings
        public abstract void OutputEarnings();

        // Abstract method for printing job description
        public abstract void OutputJobDescription();
    }
}
