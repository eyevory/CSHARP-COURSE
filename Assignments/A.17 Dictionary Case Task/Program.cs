using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A._17_Dictionary_Case_Task
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Dictionary list
            Dictionary<string, string> classes = new Dictionary<string, string>();
            // Input value saved as int
            int input = 0;

            // While loop that runs until input value is set to 4 (input cannot be set to above 4 due to code below)
            while (input < 4)
            {
                // Message menu and input saving
                Console.Write("1. Add Subject\n2. Remove Subject\n3. Show all\n4. Exit\nChoose an option between 1 and 4: ");
                input = Convert.ToInt32(Console.ReadLine());
                switch (input) // Switch case to run code based on input
                {
                    case 1: // Adds new inputted subject and teacher into dictionary
                        Console.Write("Enter the name of the new subject: ");
                        string subject = Console.ReadLine();
                        Console.Write("Teachers name: ");
                        classes[subject] = Console.ReadLine();
                        Console.WriteLine("Subject and teacher added successfully\n");
                        break;
                    case 2: // Removes inputted subject and teacher
                        Console.Write("Subject to remove: ");
                        string remove = Console.ReadLine();
                        if (classes.ContainsKey(remove)) // Checks if dictionary contains inputted subject to remove
                        {
                            classes.Remove(remove);
                            Console.WriteLine("Subject and teacher removed successfully");
                        }
                        else // Error if no subject found
                        {
                            Console.WriteLine($"Error: No subject found with name: {remove}");
                        }
                        Console.WriteLine();
                        // Not needed for wanted function
                        //Console.Write("Teacher to remove: ");
                        //classes.Remove(Console.ReadLine());
                        break;
                    case 3: // Prints out current dictionary list contents with foreach loop
                        foreach (var c in classes)
                        {
                            Console.WriteLine($"Subject: {c.Key} - Teacher: {c.Value}");
                        }
                        Console.WriteLine();
                        break;
                    case 4: // Exits program with message
                        Console.Write("Exiting...\n");
                        break;
                    default: // default when user inputs number other than 1-4 with error
                        Console.WriteLine("Error: Enter a valid number\n");
                        input = 0; // Sets input value back to 0 so loop continues
                        break;
                }
            }

            // Console.ReadLine();
        }
    }
}
