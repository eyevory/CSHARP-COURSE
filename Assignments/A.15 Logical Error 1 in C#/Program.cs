using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A._15_Logical_Error_1_in_C_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 10, 20, 5, 30, 25 };
            int max = 0;

            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] > max) // If statement was previously checking if the first index is less than "max" which starts at 0, which makes the code after never run.
                {
                    max = numbers[i];
                }
            }

            Console.WriteLine($"The maximum value in the array is: {max}");



            Console.ReadLine();
        }
    }
}
