using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A._23_TryParse_Task_in_C_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Asks for an input and stores it in string
            Console.Write("Enter a number: ");
            string errorInput = Console.ReadLine();
            int errorResult = 0;

            // While try catch works, it is worse performance wise but can give more information about the error
            try
            {
                errorResult = Convert.ToInt32(errorInput);
                Console.WriteLine($"Conversion succeeded: {errorResult}");
            }
            catch (FormatException e) // In case input is not correct format for variable
            {
                Console.WriteLine($"Error: {e.Message}");
            }

            // TryParse ends up being faster and just checks if a specific outcome is successful, also outputs a boolean which can be utilized (although it is possible to make booleans within try catch)
            bool success = int.TryParse(errorInput, out errorResult);

            if (success) // If boolean is true a.k.a if TryParse succeeded
            {
                Console.WriteLine($"Conversion succeeded, your number is: {errorResult}");
            }
            else // If TryParse is false and the conversion from string to int failed
            {
                Console.WriteLine("Error: invalid input, cannot convert to integer");
            }

            Console.ReadLine();
        }
    }
}
