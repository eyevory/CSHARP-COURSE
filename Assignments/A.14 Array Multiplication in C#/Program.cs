using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A._14_Array_Multiplication_in_C_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Variables
            int num = 7;
            int length = 5;

            // Array using prev variables
            int[] multiplicationArray = new int[length];

            // Loop to set values to array using "num" variable
            for (int i = 1; i < length + 1; i++)
            {
                multiplicationArray[i - 1] = i * num;
            }

            // Message presenting array
            Console.Write($"The multiplication table for {num} repeated {length} times is: ");

            // Loop to print the array
            foreach (int x in multiplicationArray)
            {
                Console.Write($"{x}, ");
            }

            // Overwrites last 2 characters with white space deleting them, fixes ugly "," at end of table
            Console.Write("\b \b");
            Console.Write("\b \b");

            Console.ReadLine();
        }
    }
}
