using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A._11_Message_Printer_Task
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Prompt to ask the user to input a specific message and save it to variable called message
            Console.Write("Please enter the message \"C# is fun, I am going to code C# tomorrow\": ");
            string message = Console.ReadLine();
            // char array with values of previous message input
            char[] messageArray = message.ToCharArray();
            // Reverse the array
            Array.Reverse(messageArray);

            // Print out the message
            Console.WriteLine(message);
            // Print out reversed message
            Console.WriteLine(messageArray);

            Console.WriteLine();
            
            // Loop that prints out message one letter line by line
            foreach (char c in message)
            {
                Console.WriteLine(c);
            }

            Console.WriteLine();

            // Same loop as above but message is reversed
            foreach (char c in messageArray)
            {
                Console.WriteLine(c);
            }
            
            Console.ReadLine();
        }
    }
}
