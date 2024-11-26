using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArraySorting
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Sort Array numbers
            int[] numbers = { 10, 2, 91, 4, 42, 6, 12, 809, 22 };

            Array.Sort(numbers);

            foreach (int num in numbers)
            {
                Console.Write($"{num} ");
            }

            Console.ReadLine();
        }
    }
}
