using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayClear
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[]
            {
                0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12
            };

            // Array.Clear(numbers, 0, numbers.Length);
            Array.Clear(numbers, 5, 5);

            for (int i = 5; i < 10; i++)
            {
                numbers[i] = default;
            }

            foreach (var item in numbers)
            {
                Console.Write($"{item} ");
            }

            Console.ReadLine();
        }
    }
}
