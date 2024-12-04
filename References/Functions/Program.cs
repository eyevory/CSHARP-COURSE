using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Defines the namespace for the program
namespace Functions
{
    // Class named test containing a static method
    class test
    {
        // Static method named "Something" that prints a blank
        public static void something()
        {
            Console.WriteLine("Test print using class and static method");
            Console.WriteLine();
        }
    }
    // Main program class
    internal class Program
    {
        // The startpoint of the program
        static void Main(string[] args)
        {
            // Calls the static method "something" from the test class
            test.something();

            WelcomeMessage();

            // Keeps console open until next enter input
            Console.ReadLine();
        }

        // Static method that prints a welcome message to the console (In standby when not called for due to being in same class)
        static void WelcomeMessage()
        {
            Console.WriteLine("Welcome, lets code some C#");
        }
    }
}
