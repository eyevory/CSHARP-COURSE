using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Dictionary storing strings
            Dictionary<string, string> words = new Dictionary<string, string>();
            // Int to store user input
            int input = 0;

            // While loop until input = 4
            while (input < 4)
            {
                // Print menu
                Console.Write("1. Add a word and its definition\n2. Remove a word\n3. Show all\n4. Exit the program");
                Console.Write("\n\nChoose an option: ");
                // Try-Catch to deal with invalid input
                try
                {
                    // Set input to user input
                    input = Convert.ToInt32(Console.ReadLine());
                }
                catch (FormatException)
                {
                    // If invalid input, reset to 0
                    input = 0;
                }
                // Switch case to handle menu options
                switch(input)
                {
                    case 1:
                        // User input for word and definition
                        Console.Write("Enter the word: ");
                        string word = Console.ReadLine();
                        Console.Write("Enter the definition: ");
                        string definition = Console.ReadLine();
                        // Add input to dictionary
                        words.Add(word, definition);
                        // Print success message
                        Console.WriteLine($"The word {word} and its definition added successfully\n");
                        break;
                    case 2:
                        // User input for word to remove
                        Console.Write("Input word to remove: ");
                        string remove = Console.ReadLine();
                        // Check if word exists in dictionary
                        if (words.ContainsKey(remove))
                        {
                            // Remove from dictionary
                            words.Remove(remove);
                            // Print success message
                            Console.WriteLine($"The word {remove} removed successfully");
                        }
                        else // If word does not exist
                        {
                            Console.WriteLine($"Error: No word called {remove} found");
                        }
                        Console.WriteLine();
                        break;
                    case 3:
                        Console.WriteLine("Current dictionary: ");
                        // Foreach loop through dictionary
                        foreach (var n in words)
                        {
                            // Print current contents
                            Console.WriteLine($"Word: {n.Key} - Definition: {n.Value}");
                        }
                        Console.WriteLine();
                        break;
                    case 4:
                        // Print exiting
                        Console.Write("Exiting . . .\n");
                        break;
                    default:
                        // Print invalid input if input != 1, 2, 3 or 4
                        Console.WriteLine("Invalid input\n");
                        // Reset input to 0
                        input = 0;
                        break;
                }
            }



        }
    }
}
