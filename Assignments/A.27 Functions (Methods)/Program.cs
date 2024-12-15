using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace A._27_Functions__Methods_
{
    class MathOperations
    {
        // Class properties
        public int X { get; private set; }
        public int Y { get; private set; }
        // Constructor to initialize x and y
        public MathOperations(int x, int y)
        {
            X = x;
            Y = y;
        }
        // Method to sum input
        public int Addition(int x, int y)
        {
            return x + y;
        }
        // Method to subtract input x with input y
        public int Subtraction(int x, int y) 
        { 
            return x - y; 
        }
        // Method to multiply inputs
        public int Multiplication(int x, int y)
        {
            return x * y;
        }
        // Method to divide input x with input y
        public double Divide(int x, int y)
        {
            double divResult = (double)x / (double)y;
            // Have to use .IsInfinity and .IsNaN to handle dividing by 0 or 0 / 0 with double
            if (double.IsInfinity(divResult) || double.IsNaN(divResult))
            {
                Console.WriteLine("Error: Cannot divide by zero");
                return 0.0;
            }
            else
            {
                return divResult;
            }
            // TRY CATCH DivideByZeroException DOES NOT WORK WITH FRACTIONS LIKE DOUBLE OR FLOAT, RETURNS "8" a.k.a infinity instead

            /*
            try
            {
                double divResult = x / y;
                return divResult;
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Error: Cannot divide by zero");
                return 0.0;
            }
            */
        }
        // Method to raise the number x with the power of y
        public double Power(int x, int y)
        {
            return Math.Pow(x, y);
        }
    }
    
    internal class Program
    {
        static void Main(string[] args)
        {
            // Take user input and store in variables
            Console.Write("Enter the first number: ");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the second number: ");
            int y = Convert.ToInt32(Console.ReadLine());
            // Create instance of MathOperations class
            MathOperations math = new MathOperations(x, y);

            // Print results in a nicely formatted way
            Console.WriteLine("\nResults: ");
            Console.WriteLine($"Addition: {x} + {y} = {math.Addition(x, y)}");
            Console.WriteLine($"Subtraction: {x} - {y} = {math.Subtraction(x, y)}");
            Console.WriteLine($"Multiplication: {x} * {y} = {math.Multiplication(x, y)}");
            double fraction = math.Divide(x, y);
            // Check if dividing returned 0.0 to skip printing result and only show error
            if (fraction != 0.0)
            {
                Console.WriteLine($"Division: {x} / {y} = {fraction:F2}");
            }
            // Will print 1 if raising to the power of 0, hard to elegantly fix without screwing over 1 ^ 1.
            Console.WriteLine($"Power: {x} ^ {y} = {math.Power(x, y)}");

            Console.WriteLine("\nPress any key to exit . . .");

            Console.ReadKey();
        }
    }
}
