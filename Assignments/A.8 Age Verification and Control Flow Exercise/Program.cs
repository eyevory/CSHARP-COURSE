using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A._8_Age_Verification_and_Control_Flow_Exercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // User input for age, converts input string into int
            Console.Write("Please enter your age: ");
            int age = Convert.ToInt32(Console.ReadLine());

            // Variable to set legal age
            int legalAge = 18;

            Console.WriteLine();

            // If statement checks if input age is of legal age
            if (age >= legalAge)
            {
                Console.WriteLine("You are an adult.");
            }
            else if (age < legalAge)
            {
                Console.WriteLine("You are under the legal age.");
            }
            else
            {
                Console.WriteLine("Error, invalid age");
            }
            
            Console.WriteLine();

            // Set starting counter variable
            int counter = 1;

            // While loop to increment and write out counter variable
            while (counter <= 5)
            {
                Console.WriteLine(counter);
                counter++;
            }

            // Switch case that will always end up defaulting due to counter being incremented already
            switch (counter)
            {
                case 1:
                    Console.WriteLine("One");
                    break;
                case 2:
                    Console.WriteLine("Two");
                    break;
                case 3:
                    Console.WriteLine("Three");
                    break;
                case 4:
                    Console.WriteLine("Four");
                    break;
                case 5:
                    Console.WriteLine("Five");
                    break;
                default:
                    Console.WriteLine("Invalid number");
                    break;
            }

            // John name stored as string via var
            var name = "John";

            // Message to welcome John and tell about loop
            Console.WriteLine("\nWelcome " + name + ", the loop was successful!");

            Console.ReadLine();
        }
    }
}
