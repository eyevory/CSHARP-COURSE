using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringEquals
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string pass = "123456";
            string compare = "123456";

            // Example 1
            /*
            if (pass == compare)
            {
                Console.WriteLine("Same");
            }
            else
            {
                Console.WriteLine("Diff");
            }

            // Example 2
            if (pass.Equals(compare))
            {
                Console.WriteLine("Same");
            }
            else
            {
                Console.WriteLine("Diff");
            }
            */
            // Example 3
            /*
            Console.Write("Enter your name: ");
            string name = Console.ReadLine();

            // Checks if the name is not empty
            if (!name.Equals(""))
            {
                Console.WriteLine("Your name is " + name);
            }
            // If name input is empty
            else
            {
                Console.WriteLine("Invalid name input");
            }
            */

            // Compare example
            string pass2 = "Hello";
            char[] chars = new char[] {'H', 'e', 'l', 'l', 'o' };
            object newCompare = new string(chars);

            if (pass2.Equals(newCompare))
                Console.WriteLine("Same");
            else
                Console.WriteLine("Different");
            

            Console.ReadLine();
        }
    }
}
