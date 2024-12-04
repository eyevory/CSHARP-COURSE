using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace logicError3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 1, 2, 3, 4, 5 };
            int sum = 0;

            // Since arrays start counting indexes from 0 while .Length counts the first value as 1
            // It will loop the final time with a value of 5, which the numbers array does not have a index for
            for (int i = 0; i < numbers.Length; i++) // Removing "=" from "<=" fixes the issue
            {
                sum += numbers[i];
            }

            Console.WriteLine("Sum of numbers: " + sum);
            Console.ReadLine();
        }
    }
}
