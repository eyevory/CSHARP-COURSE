using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http.Headers;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace FunctionParameters
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Example 1
            int calcu = Add(50, 50);
            Console.WriteLine(calcu);

            int num = ReadInt("Enter a number: ");
            int num2 = ReadInt("Enter a second number: ");

            int result = Add(num, num2);
            Console.WriteLine(result);
            
            /*
            // Outdated code
            // string name = StringReader();
            // Console enter your name
            string text = ReadText("Enter your message");
            Console.WriteLine(text);
            */

            // Example 2
            string name = ReadString("Enter your name: ");
            int age = ReadInt("Enter your age: ");
            string details = UserDetails(name, age);
            Console.WriteLine(details);

            Console.ReadLine();
        }

        static string UserDetails(string name, int age)
        {
            return $"Hello my name is {name} and my age is {age}!";
        }

        static string ReadString(string message)
        {
            Console.Write($"{message}");
            return Console.ReadLine();
        }

        static int ReadInt(string message)
        {
            Console.Write(message);
            return Convert.ToInt32(Console.ReadLine());

        }

        static string ReadText(string message)
        {
            Console.Write($"{message}");
            return Console.ReadLine();
        }

        static int Add(int a, int b)
        {
            return a + b;
        }
    }
}
