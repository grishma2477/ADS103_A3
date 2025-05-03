using System.Threading.Tasks;

namespace ADS103_Grishma_A00177960_Assignment3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Select Task to Run:");
            Console.WriteLine("1) Task 1 - Data Structures Search Performance");
            Console.WriteLine("2) Task 2 - Employee Max Heap Polymorphism");
            // Ask user for which Task to run
            Console.Write("Enter a number: ");

            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    Task1.Run();
                    break;
                case "2":
                    Task2.Run();
                    break;
                default:
                    Console.WriteLine("Invalid option selected.");
                    break;
            }
        }
    }
}
