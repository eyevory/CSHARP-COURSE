using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lists
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // List of numbers
            int[] numbers = new int[4]
            {
                1, 2, 3, 4
            };

            List<int> listNumbers = new List<int>();

            for(int i = 0; i < 3; i++)
            {
                Console.Write("Enter a number: ");
                listNumbers.Add(Convert.ToInt32(Console.ReadLine()));
            }

            for(int i = 0; i < listNumbers.Count; i++)
            {
                Console.WriteLine(listNumbers[i]);
            }

            // Remove value at specific index
            // listNumbers.RemoveAt(0);
            // Remove specific value in list
            listNumbers.Remove(1);

            foreach (var item in listNumbers)
            {
                Console.WriteLine(item);
            }


            Console.ReadLine();
        }
    }
}
