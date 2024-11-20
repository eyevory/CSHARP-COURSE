using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhileLoops
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // For loop example
            /*
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(i + 1);
            }
            */

            // While loop example
            /*
            int i = 0;

            while (i < 10)
            {
                i++;
                Console.WriteLine(i);
            }
            */

            Console.Write("Enter the first number: ");
            string numberAInput = Console.ReadLine();
            int numberA = Convert.ToInt32(numberAInput);

            Console.Write("Enter the second number: ");
            string numberBInput = Console.ReadLine();
            int numberB = Convert.ToInt32(numberBInput);

            int answer = numberA * numberB;
            int actualAnswer = 0;

            Console.Write("Value of " + numberA + " * " + numberB + ": ");
            Console.WriteLine();

            // While loop example that checks if input is incorrect or correct.
            // Checks before running loop
            /*
            while (answer != actualAnswer)
            {
                Console.Write("Enter your answer: ");
                string answerInput = Console.ReadLine();
                actualAnswer = Convert.ToInt32(answerInput);

                if(answer != actualAnswer)
                {
                    Console.WriteLine("Incorrect.");
                }
            }
            */

            // Do while example
            // Do while will execute the code at least once first before checking if the statement is true
            do
            {
                Console.Write("Enter your answer: ");
                string answerInput = Console.ReadLine();
                actualAnswer = Convert.ToInt32(answerInput);
                if (answer != actualAnswer)
                {
                    Console.WriteLine("Incorrect.\n");
                }
            } while (answer != actualAnswer);

            Console.WriteLine("Well done!");

            Console.ReadLine();
        }
    }
}
