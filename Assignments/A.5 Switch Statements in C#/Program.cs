using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A._5_Switch_Statements_in_C_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Takes user input and converts it into int variable and stores it
            Console.Write("Please enter your grade: ");
            int grade = Convert.ToInt32(Console.ReadLine());

            // Switch case to check user input value and returns message based on value
            switch(grade)
            {
                case 0:
                    Console.WriteLine("Fail");
                    break;
                case 1:
                    Console.WriteLine("Needs Improvement");
                    break;
                case 2:
                    Console.WriteLine("Ok");
                    break;
                case 3:
                    Console.WriteLine("Satisfactory");
                    break;
                case 4:
                    Console.WriteLine("Good");
                    break;
                case 5:
                    Console.WriteLine("Excellent");
                    break;
                default: // In case user inputs value outside 0 to 5
                    Console.WriteLine("Invalid input, has to be from 0 to 5");
                    break;
            }


            Console.ReadLine();
        }
    }
}
