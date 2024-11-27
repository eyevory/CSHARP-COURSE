using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A.EX_C__Food_List
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Create list
            List<string> shoppingList = new List<string>();
            
            // bool to use in while loop
            bool stop = true;
            
            // while loop to add input to list
            while (stop)
            {
                Console.Write("Enter item to add to shopping list (input \"stop\" when done): ");
                shoppingList.Add(Console.ReadLine());
                if (shoppingList.Contains("stop")) // When user inputs stop to end the loop
                    {
                    shoppingList.Remove("stop");
                    stop = false;
                    }
                    
            }

            Console.WriteLine("\nYour shopping list: ");

            // for loop to print out list after use input
            for (int i = 0; i < shoppingList.Count; i++)
            {
                Console.WriteLine(shoppingList[i]);
            }

            Console.ReadLine();
        }
    }
}
