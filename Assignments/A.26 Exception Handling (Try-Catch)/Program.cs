using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A._26_Exception_Handling__Try_Catch_
{
    class Calculator
    {
        // Class properties
        public int X;
        public int Y;
        // Constructor to initialize x and y
        public Calculator(int x, int y)
        {
            X = x;
            Y = y;
        }

        // Method to divide two input integers
        public double Divide(int x, int y)
        {
            double divResult = (double)x / (double)y;
            // Have to use .IsInfinity and .IsNaN to handle dividing by 0 or 0 / 0 with double, try catch only works if using integers
            if (double.IsInfinity(divResult) || double.IsNaN(divResult))
            {
                Console.WriteLine("Error: Cannot divide by zero");
                return 0.0;
            }
            else
            {
                return divResult;
            }
            // TRY CATCH DivideByZeroException DOES NOT WORK IF OUTPUT IS DOUBLE OR FLOAT. WILL RETURN "8" (Infinity)

            /*
            try
            {
                double divResult = (double)x / (double)y;
                return divResult;
            }
            catch (DivideByZeroException) // If denominator is 0
            {
                Console.WriteLine("Error: Can't divide by zero");
                return 0.0;
            }
            */

            /*
            catch (FormatException)
            {
                Console.WriteLine("Error: Input two whole numbers");
                return 0.0;
            }
            */
        }
        // Method to take string input and convert it to int
        public int ParseInput(string input)
        {
            // Try-Catch to catch format exceptions if user inputs something else than numbers
            try
            {
                int convInput = Convert.ToInt32(input);
                //int.TryParse(input, out int convInput);
                return convInput;
            }
            catch (FormatException) // In case input is not a whole number
            {
                Console.WriteLine("Error: Only input whole numbers");
                return 0; // INTENTIONALLY MADE 0 INSTEAD OF -1 FROM ASSIGNMENT TO MAKE LOOP BELOW WORK EASIER
            }
        }

    }

    internal class Program
    {
        static void Main(string[] args)
        {
            //try
            //{

            // Variables and instance of "Calculator" class
            bool loop = true;
            int x = 0;
            int y = 0;
            Calculator calc = new Calculator(x, y);
            // While loop that keeps going until answer is something else than 0
            while (loop)
            {
                // User input and calling methods from Calculator class
                Console.WriteLine("Division calculator");
                Console.Write("Enter the numerator: ");
                x = calc.ParseInput(Console.ReadLine());
                Console.Write("Enter the denominator: ");
                y = calc.ParseInput(Console.ReadLine());
            
                double fraction = calc.Divide(x, y);

                // Print result
                Console.WriteLine($"Result: {fraction}\n");
                // If the answer was 0: repeat, otherwise keep looping
                if (fraction != 0)
                {
                   loop = false;
                }
            }
            //}
            //catch (FormatException)
            //{
            //    Console.WriteLine("Error: Only enter whole numbers");
            //}

            Console.ReadLine();
        }
    }
}