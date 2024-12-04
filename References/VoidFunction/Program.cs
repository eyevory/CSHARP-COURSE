using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace voidFunction
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Message();
            CreateAndPrintArray();
            Console.ReadLine();
        }

        static void CreateAndPrintArray()
        {
            int[] number = new int[5] { 0, 1, 2, 3, 4 };
            foreach (var item in number)
            {
                Console.Write($"{item} ");
            }
        }

        static void Message()
        {
            Console.WriteLine("Count from 0 to 4!");
        }
    }
}
