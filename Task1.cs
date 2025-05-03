using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADS103_Grishma_A00177960_Assignment3
{
    class Task1
    {
        public static void Run()
        {
            // List to store all numbers (sequential search)
            List<int> list = new List<int>();

            // HashSet to ensure uniqueness of generated numbers
            HashSet<int> uniqueNumbers = new HashSet<int>();

            // Initialize custom Binary Search Tree and AVL Tree objects
            BST bst = new BST();
            AVLTree avl = new AVLTree();

            // Random number generator
            Random rand = new Random();

            Console.WriteLine("Inserting 150,000 unique random numbers into data structures...");

            // Generate 150,000 unique random numbers between 1 and 999,999
            while (uniqueNumbers.Count < 150000)
            {
                int num = rand.Next(1, 1000000);

                // Only add if the number is unique (HashSet ensures this)
                if (uniqueNumbers.Add(num))
                {
                    Console.WriteLine(num);        // Optional: display inserted number
                    list.Add(num);                // Add to List
                    bst.Insert(num);              // Insert into Binary Search Tree
                    avl.Insert(num);              // Insert into AVL Tree
                }
            }

            Console.WriteLine($"Insertion completed. Total: {uniqueNumbers.Count} \n");

            // Start menu-driven interaction
            while (true)
            {
                Console.WriteLine("Select an option:\n1) Search for a number in all data structures\n2) Exit");
                string choice = Console.ReadLine();

                // Exit condition
                if (choice == "2") break;

                // Only process option 1
                if (choice != "1") continue;

                // Ask user for a number to search
                Console.Write("Enter a number to search: ");
                if (!int.TryParse(Console.ReadLine(), out int target))
                {
                    Console.WriteLine("Invalid input. Try again.\n");
                    continue;
                }

                // Measure search time in List
                Stopwatch sw = Stopwatch.StartNew();
                bool foundInList = list.Contains(target);
                sw.Stop();
                Console.WriteLine(foundInList
                    ? $"List: Found in {sw.Elapsed.TotalMilliseconds} ms"
                    : $"List: Not found in {sw.Elapsed.TotalMilliseconds} ms");

                // Measure search time in BST
                sw.Restart();
                bool foundInBST = bst.Search(target);
                sw.Stop();
                Console.WriteLine(foundInBST
                    ? $"BST: Found in {sw.Elapsed.TotalMilliseconds} ms"
                    : $"BST: Not found in {sw.Elapsed.TotalMilliseconds} ms");

                // Measure search time in AVL Tree
                sw.Restart();
                bool foundInAVL = avl.Search(target);
                sw.Stop();
                Console.WriteLine(foundInAVL
                    ? $"AVL Tree: Found in {sw.Elapsed.TotalMilliseconds} ms\n"
                    : $"AVL Tree: Not found in {sw.Elapsed.TotalMilliseconds} ms\n");
            }
        }
    }
}
