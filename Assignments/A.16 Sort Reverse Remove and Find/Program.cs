using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A._16_Sort_Reverse_Remove_and_Find
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Array
            int[] numbers = { 45, 12, 78, 34, 89, 23 };

            // Print array in original order
            Console.Write("Original: ");
            foreach (int x in numbers)
            {
                Console.Write($"{x} ");
            }

            // Sort in ascending
            Array.Sort(numbers);
            // Print array after sort
            Console.Write("\nAscending: ");
            foreach (int x in numbers)
            {
                Console.Write($"{x} ");
            }
            
            // Reverse array
            Array.Reverse(numbers);
            // Print after reversing
            Console.Write("\nReversed: ");
            foreach (int x in numbers)
            {
                Console.Write($"{x} ");
            }

            // Convert array to list, use RemoveAt list command to remove 78 from the list, convert back to array
            int numToRemove = 78;
            int numIdx = Array.IndexOf(numbers, numToRemove);
            List<int> tmp = new List<int>(numbers);
            tmp.RemoveAt(numIdx);
            numbers = tmp.ToArray();

            // Print after removing the element 78 from array
            Console.Write("\nNr 78 removed: ");
            foreach (int x in numbers)
            {
                Console.Write($"{x} ");
            }

            // User input for element to lookup
            Console.Write("\n\nSearch up number in array: ");
            int search = Convert.ToInt32(Console.ReadLine());
            int position = Array.IndexOf(numbers, search);

            // Checks if user input matches an element in array and its index if it exists
            if (position > -1)
            {
                Console.WriteLine($"The position of {search} is: {position + 1}"); 
            }
            else
            {
                Console.WriteLine($"Error: The number {search} does not exist in the array");
            }
            Console.ReadLine();
        }
    }
}
