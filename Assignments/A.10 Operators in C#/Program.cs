using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A._10_Operators_in_C_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Define six int variables
            int num1 = 2;
            int num2 = 4;
            int num3 = 6;
            int num4 = 8;
            int num5 = 12;
            int num6 = 7;

            // Write out result of simple operations using variables
            Console.WriteLine(num1 + num2);
            Console.WriteLine(num3 * num4);
            Console.WriteLine(num5 / num6);

            Console.WriteLine();

            // Prefix and postfix incrementing and decrementing on num6 variable
            Console.WriteLine(num6++); // Prints first then increments
            Console.WriteLine(++num6); // Increments first then prints
            Console.WriteLine(num6--); // Same as above but decrements
            Console.WriteLine(--num6);

            Console.WriteLine();

            // Compound assignment operators on num5 variable giving the variable a new value based on the result of each operation
            Console.WriteLine(num5 += num3);
            Console.WriteLine(num5 -= num3);
            Console.WriteLine(num5 *= num3);
            Console.WriteLine(num5 /= num1);
            Console.WriteLine(num5 %= num6);

            Console.ReadLine();
        }
    }
}
