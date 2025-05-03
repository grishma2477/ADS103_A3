using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADS103_Grishma_A00177960_Assignment3
{
    class Task2
    {
        public static void Run()
        {
            MaxHeap employeeHeap = new MaxHeap();

            // Insert various employees into the heap
            employeeHeap.Insert(new Janitor("Alice", 30000));
            employeeHeap.Insert(new Programmer("Bob", 50000, 120, 10));
            employeeHeap.Insert(new CEO("Cathy", 100000, 20000));
            employeeHeap.Insert(new Programmer("David", 60000, 150, 20));
            employeeHeap.Insert(new Janitor("Eve", 32000));
            employeeHeap.Insert(new CEO("Frank", 95000, 15000));
            employeeHeap.Insert(new Programmer("Grace", 52000, 90, 5));
            employeeHeap.Insert(new CEO("Henry", 105000, 10000));
            employeeHeap.Insert(new Programmer("Ivy", 58000, 100, 8));
            employeeHeap.Insert(new Janitor("Jack", 31000));

            // Extract employees one by one in descending order of salary and show their info
            while (!employeeHeap.IsEmpty())
            {
                Employee top = employeeHeap.ExtractMax();
                top.OutputJobDescription();
                top.OutputEarnings();
                Console.WriteLine();
            }
        }
    }
}
