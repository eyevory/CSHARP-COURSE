using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringNullOrEmpty
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter your name: ");
            string name = Console.ReadLine();

            Console.WriteLine($"Your name is {name}");
            /*
            if (name != "")
                Console.WriteLine("0");

            if (!name.Equals("")) 
                Console.WriteLine("1");

            if (string.IsNullOrEmpty(name))
                Console.WriteLine("2");
            */

            if (!string.IsNullOrEmpty(name))
            {
                if (name.Equals("Bob"))
                {
                    Console.WriteLine("Correct name");
                }
                else
                {
                    Console.WriteLine("Wrong name");
                }
            }


            Console.ReadLine();
        }
    }
}
