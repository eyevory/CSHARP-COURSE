using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ErrorMessages
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                // User input
                Console.Write("Enter a number: ");

                // Reads user input and converts it to integer and stores it
                int num = Convert.ToInt32(Console.ReadLine());

                // Prints the stored value
                Console.WriteLine(num);
            }
            // Catch that handles invalid input formats (letters)
            catch (FormatException)
            {
                Console.WriteLine($"Please only enter numbers!");
            }
            // Catch for handling numbers that are too big or small
            catch (OverflowException)
            {
                Console.WriteLine($"Please enter a value lower than 2 billion!");
            }
            // Catch fo rhandling any other exceptions
            catch (Exception ex)
            {
                // Displays generic error message
                Console.WriteLine($"Error: {ex.Message}");
            }

            Console.WriteLine("Bye bye...");

            Console.ReadLine();
        }
    }
}
