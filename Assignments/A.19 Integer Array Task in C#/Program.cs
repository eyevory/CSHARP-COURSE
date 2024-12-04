using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Integer_Array_Task_in_C_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Array
            int[] numbers = new int[]
            {
                0, 1, 2, 3, 4, 5
            };

            // Variable calling method to sum array
            int sum = SumOfNumbers(numbers);

            // Print array sum and length
            Console.WriteLine(sum);
            Console.WriteLine(numbers.Length);
            
            // Scuffed If statements without much meaning
            // Checks if array sum is positive
            if (sum > -1)
            {
                Console.WriteLine($"The total is: {sum}");
            }
            else
            {
                Console.WriteLine("Cannot add up an empty array");
            }

            // Checks if array sum is negative
            if (sum < 0)
            {
                Console.WriteLine($"The total is: {sum}");
            }
            else
            {
                Console.WriteLine("Cannot add up an empty array");
            }

            Console.ReadLine();
        }

        // Method to sum an array of integers
        static int SumOfNumbers(int[] arr)
        {
            return arr.Sum();
        }
    }
}
