using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADS103_Grishma_A00177960_Assignment3
{
    // Represents a janitor employee
    class Janitor : Employee
    {
        public Janitor(string name, int salary) : base(name, salary) { }

        public override void OutputEarnings()
        {
            Console.WriteLine($"Earnings: ${salary}");
        }

        public override void OutputJobDescription()
        {
            Console.WriteLine($"Janitor: {name}, keeps the workplace clean.");
        }
    }
}
