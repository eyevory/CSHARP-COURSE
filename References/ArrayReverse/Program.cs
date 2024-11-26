using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayReverse
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[]
            {
                0, 1, 2, 3, 4, 5, 6, 7, 8, 9
            };

            // Array Reverse
            /*
            Array.Reverse(numbers);

            foreach (var item in numbers)
            {
                Console.Write($"{item} ");
            }
            */

            int[] sortedNumbers = new int[numbers.Length];
            int x = 0;

            for (int i = numbers.Length -1; i >= 0; i--)
            {
                sortedNumbers[x] = numbers[i];
                x++;
            }

            foreach (var num in sortedNumbers)
            {
                Console.Write($"{num} ");
            }
            Console.ReadLine();
        }
    }
}
