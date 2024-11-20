using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A._4_If_Statements_in_C_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Takes user input, converts and stores it in "age" variable as int
            Console.Write("Please enter your age: ");
            int age = Convert.ToInt32(Console.ReadLine());

            // If statement to check if inputted age is above 18
            if (age >= 18)
            {
                Console.WriteLine("You can vote!");
            }
            else
            {
                Console.WriteLine("You can't vote yet...");
            }


            Console.ReadLine();
        }
    }
}
