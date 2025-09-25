using System;
using FibGrokLib; // Namespace của DLL

namespace FibGrokConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter position n for Fibonacci (non-negative integer):");
            string input = Console.ReadLine();
            int n;
            if (int.TryParse(input, out n) && n >= 0)
            {
                FibonacciCalculator calc = new FibonacciCalculator();
                calc.Position = n;
                calc.Calculate();
                Console.WriteLine("Result: " + calc.Result);
            }
            else
            {
                Console.WriteLine("Invalid input! - HungLanBTVN");
            }
            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
    }
}