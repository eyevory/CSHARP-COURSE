using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IfStatements
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            // User input for "name"
            Console.Write("Enter your name: ");
            string name = Console.ReadLine();

            // User input for "age" and convert input to int
            Console.Write("Enter your age: ");
            string ageInput = Console.ReadLine();
            int age = Convert.ToInt32(ageInput);

            // Writes it out
            Console.WriteLine();
            Console.WriteLine("Your name is " + name + " and your age is " + age + ".");

            // If check on age input
            // == > >= < <= && ||
            */

            /*
            if (age >= 18 && age <=20)
            {
                Console.WriteLine("You are between 18 and 20.");
            }
            else if(age >= 20)
            {
                Console.WriteLine("You are 20 or older.");
            }
            */

            /*
            if (age <= 0 || age > 150)
            {
                Console.WriteLine("Invalid age.");
            }
            else
            {
                if(age >= 18 && age <= 20)
                {
                    Console.WriteLine("You are between 18 and 20");
                }
                else if (age >= 21)
                {
                    Console.WriteLine("You are 21 or older");
                }
            }
            */

            // User input for numberA
            Console.Write("Enter the first number: ");
            string numberAInput = Console.ReadLine();
            int numberA = Convert.ToInt32(numberAInput);

            // User input for numberB
            Console.Write("Enter the second number: ");
            string numberBInput = Console.ReadLine();
            int numberB = Convert.ToInt32(numberBInput);

            // Int variable answer based on previous input
            // + - * /
            int answer = numberA * numberB;

            // Console.WriteLine("Value of " + numberA + " * " + numberB + " = " + answer);
            Console.Write("What is the value of " + numberA + " * " + numberB + " = ");

            // User input to guess answer
            string answerInput = Console.ReadLine();
            int actualAnswer = Convert.ToInt32(answerInput);

            // If statement to check if previous user guess was correct or wrong
            if (answer == actualAnswer)
            {
                Console.WriteLine("Correct.");
            }
            else if (answer != actualAnswer)
            {
                Console.WriteLine("Wrong.");
            }


            Console.ReadKey();
        }
    }
}
