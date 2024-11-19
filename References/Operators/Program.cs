using System;

namespace Operators
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Example 1
            double age = 27;
            // + - * / interchangeable for the + in the next line
            age += 10;
            Console.WriteLine(age);

            // Example 2
            string name = "Bob";
            name += " is programming!";
            Console.WriteLine(name);

            // Example 3
            char ab = 'a';
            ab += 'b';
            Console.WriteLine(ab);

            // Example 4
            int i = 0;
            Console.WriteLine(i++ + "\n" + i);

            Console.ReadKey();
        }
    }
}
