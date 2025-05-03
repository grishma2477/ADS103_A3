using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADS103_Grishma_A00177960_Assignment3
{
    // Represents a CEO employee
    class CEO : Employee
    {
        private int annualBonus;

        public CEO(string name, int salary, int annualBonus) : base(name, salary)
        {
            this.annualBonus = annualBonus;
        }

        public override void OutputEarnings()
        {
            Console.WriteLine($"Earnings: ${salary + annualBonus}");
        }

        public override void OutputJobDescription()
        {
            Console.WriteLine($"CEO: {name}, manages the company. Annual bonus: ${annualBonus}");
        }
    }
}
