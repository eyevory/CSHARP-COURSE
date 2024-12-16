using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Array containing strings
            string[] names = new string[]
            {
                "Bob", "Steve", "Nina"
            };
            // Array containing integers
            int[] numbers = new int[]
            {
                5, 57, 87, 1, 150, 32, 14
            };
            // foreach loop through string array
            foreach(var name in names)
            {
                // Add message alongside printing names
                Console.WriteLine($"Goodbye {name}");
            }

            // Sort int array in ascending
            Array.Sort(numbers);
            // Copy array into new array with final element removed
            Array.Resize(ref numbers, numbers.Length - 1);

            Console.WriteLine("\nSorted array, last element removed: ");
            // foreach loop through int array
            foreach(var num in  numbers)
            {
                // Print numbers
                Console.Write($"{num} ");
            }
            Console.WriteLine("\n\nPress any key to exit . . .");

            Console.ReadKey();
        }
    }
}
