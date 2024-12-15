using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace logicError2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int age = 30;

            // While keeping the same if statement logic, simply making the requirements needing to meet an upper and lower limit makes else statements work
            if (age > 18 && age < 30) // && (AND operator to check if it's under 30 added)
            {
                Console.WriteLine("Over 18");
            }
            else if (age > 30 && age < 50) // && (AND operator to check if it's under 50 added)
            {
                Console.WriteLine("Over 30");
            }
            else if (age > 50)
            {
                Console.WriteLine("Over 50");
            }
            else // if under 18
            {
                Console.WriteLine("Under 18");
            }
            Console.ReadLine();
        }
    }
}