using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1 = 5;
            int num2 = 50;
            int num3 = 500;

            // int[] numbers = new int[5]; // Arrays start at 0 (0, 1, 2)

            // Hard coded example
            /*
            numbers[0] = num1;
            numbers[1] = num2;
            numbers[2] = num3;
            */

            /*
            Console.Write("Enter a number: ");
            numbers[0] = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter a second number: ");
            numbers[1] = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter a third number: ");
            numbers[2] = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter a fourth number: ");
            numbers[3] = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter a fifth number: ");
            numbers[4] = Convert.ToInt32(Console.ReadLine());
            

            Console.WriteLine($"{num1}, {num2}, {num3}");
            Console.WriteLine($"{numbers[0]}, {numbers[1]}, {numbers[2]}");
            */

            // Example 2 loop array length
            int[] numbers = new int[5]; // Arrays start at 0 (0, 1, 2)

            for (int i = 0; i < numbers.Length; i++)
            {
                Console.Write("Enter a number: ");
                numbers[i] = Convert.ToInt32(Console.ReadLine());
            }

            // Loop the length
            for(int i = 0; i < numbers.Length; i++)
            {
                Console.Write($"{numbers[i]}, ");
            }

            Console.WriteLine();

            // For each
            foreach (int num in numbers)
            {
                Console.Write($"{num} ");
            }

            Console.ReadLine();
        }
    }
}
