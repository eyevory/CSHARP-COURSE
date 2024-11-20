using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForLoops
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Inefficient way to print multiple numbers
            /*
            Console.WriteLine("1");
            Console.WriteLine("2");
            Console.WriteLine("3");
            Console.WriteLine("4");
            Console.WriteLine("5");
            */


            // For loop examples
            /*
            for(int i = 0; i < 5; i++)
            {
                Console.WriteLine(i + 1);
            }

            for(int i = 1; i <= 10; i+=2)
            {
                Console.WriteLine(i);
            }
            */

            // For loop with user inputted loop amount
            /*
            Console.Write("How many times do you want to loop?: ");
            int loopCounter = Convert.ToInt32(Console.ReadLine());

            if (loopCounter <= 0)
            {
                Console.WriteLine("Invalid value, use a value larger than 0");
            }
            else
            {
                for (int i = 0; i < loopCounter; i++)
                {
                    Console.WriteLine("Loop: " + (i + 1));
                }
            }
            */
            
            Console.Write("What do you want to repeat?: ");
            string message = Console.ReadLine();

            Console.Write("How many times do you want to repeat?: ");
            int loopCounter = Convert.ToInt32(Console.ReadLine());

            if (loopCounter <= 0)
            {
                Console.WriteLine("Invalid value, use a value larger than 0");
            }
            else
            {
                for (int i = 0; i < loopCounter; i++)
                {
                    Console.WriteLine(message);
                }
            }


            Console.ReadLine();
        }
    }
}
