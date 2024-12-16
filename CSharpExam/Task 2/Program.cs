using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Try-Catch to deal with invalid input
            try
            {
                // User input and conversion
                Console.Write("Enter a whole number: ");
                int input = Convert.ToInt32(Console.ReadLine());

                // If statement to check if number is positive, negative or 0
                if (input == 0) // if exactly 0
                {
                    Console.WriteLine("The number is zero");
                }
                else if (input > 0) // if larger than 0
                {
                    Console.WriteLine("The number is positive");
                }
                else // if less than 0
                {
                    Console.WriteLine("The number is negative");
                }
            }
            catch (FormatException) // FormatException if invalid input (not int)
            {
                Console.WriteLine("Invalid input");
            }

            Console.ReadLine();
        }
    }
}
