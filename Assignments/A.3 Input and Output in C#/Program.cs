using System;

namespace InputOutputInCSHARP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Write out asking the user for name
            Console.Write("Enter your name: ");
            // User input stored in string variable
            string nameInput = Console.ReadLine();
            // Write out name with welcome message
            Console.WriteLine("Welcome " + nameInput + ".");

            Console.ReadKey();
        }
    }
}
