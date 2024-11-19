using System;

/*
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
*/

namespace Variables
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Changes Title
            Console.Title = "Basics";

            // Ctrl + K + C to fully comment selection
            // Ctrl + K + U to uncomment

            // Variables
            int number = 64;
            char letter = 'A';
            float body = 98.7f;
            double pi = 3.14159;
            bool flag = false;
            decimal sum = 1000.00m;
            string text = "Daily C#";

            // Writeline
            // Example
            Console.WriteLine("int number:\t" + number);
            Console.WriteLine("char letter:\t" + letter);
            Console.WriteLine("float body:\t" + body);
            Console.WriteLine("double pi:\t" + pi);
            Console.WriteLine("bool flag:\t" + flag);
            Console.WriteLine("decimal sum:\t" + sum);
            Console.WriteLine("string text:\t" + text);

            // Reading Input
            /*
            Console.Write("\nPlease enter a number: ");
            double num = Convert.ToDouble(Console.ReadLine());
            Console.Write("Now enter a number: ");
            double sum2 = num + Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Total = " + sum2);
            */
            // Example 2
            Console.Write("Please enter your name: ");
            string name = Console.ReadLine();
            Console.WriteLine("Welcome " + name + "!");

            // DataTypes
            int age = -23;
            Console.WriteLine(age);
            Console.WriteLine(int.MaxValue);
            Console.WriteLine(int.MinValue);

            long bigNumber = -900000000L;
            Console.WriteLine(bigNumber);
            Console.WriteLine(long.MaxValue);
            Console.WriteLine(long.MinValue);

            double negative = -55.2;
            Console.WriteLine(negative);
            Console.WriteLine(double.MaxValue);
            Console.WriteLine(double.MinValue);

            float precision = 5.000001f;
            Console.WriteLine(precision);
            Console.WriteLine(float.MaxValue);
            Console.WriteLine(float.MinValue);

            decimal money = 14.99M;
            Console.WriteLine(money);
            Console.WriteLine(decimal.MaxValue);
            Console.WriteLine(decimal.MinValue);

            Console.ReadKey();
        }
    }
}
