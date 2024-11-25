using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A._12_Password_Checker_Task
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // User input for password
            Console.Write("Please enter your password: ");
            string password1 = Console.ReadLine();
            // User input to repeat password
            Console.Write("Please enter your password again: ");
            string password2 = Console.ReadLine();

            // If statements to check various properties of the inputted password
            if (string.IsNullOrEmpty(password1) || string.IsNullOrEmpty(password2)) // Checks if either input was empty or null and returns message
            {
                Console.WriteLine("Please enter a password");
            }
            else if (password1.Length < 6 || password2.Length < 6) // Checks if the password is less than 6 characters, prints out that it is too short
            {
                Console.WriteLine("Password too short! Must be at least 6 characters");
            }
            else if (password1 == password2) // Checks if the passwords match each other
            {
                Console.WriteLine("Passwords match");
            }
            else // If they do not match
            {
                Console.WriteLine("Passwords do not match");
            }
            
            Console.ReadLine();
        }
    }
}
