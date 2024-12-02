using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dictionary
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Example 1
            // Dictionary with int and string variables
            /*
            Dictionary<int, string> names = new Dictionary<int, string>
            {
                {1, "Bob" },
                {2, "Steve" },
                {3, "Abe" }
            };

            // For loop to print values
            for (int i = 0; i < names.Count; i++)
            {
                KeyValuePair<int, string> pair = names.ElementAt(i);
                Console.WriteLine($"{pair.Key} - {pair.Value}");
            }

            Console.WriteLine();

            // Foreach loop to print values
            foreach (KeyValuePair<int, string> item in names)
            {
                Console.WriteLine($"{item.Key} - {item.Value}");
            }
            */
            // Example 2

            Dictionary<string, string> teachers = new Dictionary<string, string>
            {
                {"PU", "Tom" },
                {"PU2", "Anton" },
                {"Svenska", "Lotta" },
            };

            if (teachers.TryGetValue("Svenska", out string teacher))
            {
                Console.WriteLine(teacher);
                // Adds math teacher to dictionary
                teachers["Math"] = "Bob";
            }
            else
            {
                Console.WriteLine("PU teacher not found");
            }

            // Removes math teacher by checking if dictionary contains Math
            if (teachers.ContainsKey("Math"))
            {
                teachers.Remove("Mathh");
            }
            else
            {
                Console.WriteLine("Math teacher not found");
            }

            // Foreach print out from dictionary
            foreach (var item in teachers)
            {
                Console.WriteLine($"{item.Key} - {item.Value}");
            }

            Console.ReadLine();
        }
    }
}
