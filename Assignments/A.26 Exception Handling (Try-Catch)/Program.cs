using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A._26_Exception_Handling__Try_Catch_
{
    class Calculator
    {
        public int X;
        public int Y;

        public Calculator(int x, int y)
        {
            X = x;
            Y = y;
        }

        public double Divide(int x, int y)
        {
            try
            {
                double dX = (double)x;
                double dY = (double)y;
                return dX / dY;
            }
            catch (DivideByZeroException) 
            {
                Console.WriteLine("Error: Can't divide by zero");
                return 0.0;
            }
            catch (FormatException)
            {
                Console.WriteLine("Error: Input two whole numbers");
                return 0.0;
            }
        }

        public int ParseInput(string input)
        {
            try
            {
                // int convInput = Convert.ToInt32(input);
                int.TryParse(input, out int convInput);
            }
            catch (FormatException)
            {
                Console.WriteLine("Error: Only input whole numbers");
                return 0;
            }
            finally
            {
                return convInput;
            }
        }

    }
    
    internal class Program
    {
        static void Main(string[] args)
        {
            //try
            //{
            //bool loop = true;
            int x = 0;
            int y = 0;
            Calculator calc = new Calculator(x, y);
            //while (loop)
            //{
                Console.Write("Enter the numerator: ");
                x = calc.ParseInput(Console.ReadLine());
                Console.Write("Enter the denominator: ");
                y = calc.ParseInput(Console.ReadLine());
                double fraction = calc.Divide(x, y);
                Console.WriteLine($"Result: {fraction}");
             //   if (fraction != 0)
             //   {
             //       loop = false;
             //   }
            //}
            //}
            //catch (FormatException)
            //{
            //    Console.WriteLine("Error: Only enter whole numbers");
            //}

            Console.ReadLine();
        }
    }
}
