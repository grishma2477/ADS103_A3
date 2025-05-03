using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADS103_Grishma_A00177960_Assignment3
{
    // Represents a programmer employee
    class Programmer : Employee
    {
        private int bugsFixed;
        private int bugsCreated;

        public Programmer(string name, int salary, int bugsFixed, int bugsCreated) : base(name, salary)
        {
            this.bugsFixed = bugsFixed;
            this.bugsCreated = bugsCreated;
        }

        public override void OutputEarnings()
        {
            Console.WriteLine($"Earnings: ${salary}");
        }

        public override void OutputJobDescription()
        {
            Console.WriteLine($"Programmer: {name}, fixed {bugsFixed} bugs, created {bugsCreated} bugs.");
        }
    }
}
