using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A._7_While_Loops_in_C_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Defining int variable to use in while loop
            int counter = 1;

            // While loop that outputs current value of int variable up to 5
            while (counter <= 5)
            {
                Console.WriteLine(counter);
                counter++;
            }

            // End message after loops finish
            Console.WriteLine("Loop has finished!");

            Console.ReadLine();
        }
    }
}
