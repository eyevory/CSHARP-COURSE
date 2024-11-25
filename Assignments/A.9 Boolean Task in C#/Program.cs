using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A._9_Boolean_Task_in_C_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Int variables
            int num1 = 3;
            int num2 = 4;
            int num3 = 5;
            int num4 = 3;

            bool isTrue = true;

            // AND, OR and NOT operands, writing out the result
            Console.WriteLine(isTrue && (num1 > num3) && (num2 > num4));
            Console.WriteLine(isTrue || (num1 < num3) || (num2 < num4));
            Console.WriteLine(!isTrue);

            // Alternate way to check that can handle equals and with nicer text output
            /*
            if (num1 > num3)
            {
                Console.WriteLine($"{num1} is greater than {num3}");
            }
            else
            {
                Console.WriteLine($"{num1} is equal or lesser than {num3}");
            }
            */
            Console.WriteLine();

            // Checks various statements and writes it out, can't deal with equal numbers if for example all are the same number.
            Console.WriteLine($"Is {num1} greater than {num3}?: {num1 > num3}");
            Console.WriteLine($"Is {num2} less than {num4}?: {num2 < num4}");
            Console.WriteLine($"Is {num1} equal to {num4}?: {num1 == num4}");
            Console.WriteLine($"Is {num2} not equal to {num3}?: {num2 != num3}");

            // Define two boolean variables
            bool expression1 = (num1 > num3) && (num2 < num4);
            bool expression2 = (num1 < num3) && (num2 > num4);

            // Write them out
            Console.WriteLine("\nexpression1 is: " + expression1);
            Console.WriteLine("expression2 is: " + expression2);

            Console.ReadLine();
        }
    }
}
