using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Print asking user for input and store input in variables while converting them
            // User needs to use commas "," over points "." for decimals
            Console.Write("Enter an integer: ");
            int inputInt = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter a double: ");
            double inputDouble = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter a float: ");
            float inputFloat = Convert.ToSingle(Console.ReadLine());
            Console.Write("Enter a string: ");
            string inputString = Console.ReadLine();

            // Print user input with appropriate text
            Console.WriteLine($"\nYour integer: {inputInt}");
            Console.WriteLine($"Your double: {inputDouble}");
            Console.WriteLine($"Your float: {inputFloat}");
            Console.WriteLine($"Your string: {inputString}");

            // Print out short explanations on what the variables are
            Console.WriteLine("\nAn int or integer is a whole number");
            Console.WriteLine("A double is a number with ~15 decimal digit accuracy (64-bit)");
            Console.WriteLine("A float is a number with 7 decimal digit accuracy (32-bit)");
            Console.WriteLine("A string is just text");


            Console.ReadLine();
        }
    }
}
