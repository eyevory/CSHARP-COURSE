using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A._13_Odd_or_Even_C_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Asks user for number input and stores as int
            Console.Write("Please enter a number: ");
            int number = Convert.ToInt32(Console.ReadLine());

            // Checks if input is even or odd
            if (number % 2 == 0) // Even
            {
                Console.WriteLine($"The number {number} is even.");
            }
            else // Odd
            {
                Console.WriteLine($"The number {number} is odd.");
            }

            Console.ReadLine();
        }
    }
}
