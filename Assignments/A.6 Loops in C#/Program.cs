using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A._6_Loops_in_C_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // User input on amount of loops, converted to int and stored in "loopAmount"
            Console.Write("How many times do you want to loop?: ");
            int loopAmount = Convert.ToInt32(Console.ReadLine());

            // For loop that keeps looping until user value reached
            for (int i = 0; i < loopAmount; i++)
            {
                Console.WriteLine("Loop: " + (i + 1));
            }

            // End message after loop is done
            Console.WriteLine("\nFinished looping!");

            Console.ReadLine();
        }
    }
}
