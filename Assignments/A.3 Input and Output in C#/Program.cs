using System;

namespace InputOutputInCSHARP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter your name: ");
            string nameInput = Console.ReadLine();
            Console.WriteLine("Welcome " + nameInput + ".");

            Console.ReadKey();
        }
    }
}
