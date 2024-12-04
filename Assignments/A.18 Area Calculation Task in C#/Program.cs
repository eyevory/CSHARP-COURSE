using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A._18_Area_Calculation_Task_in_C_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Message and inputs for width and height stored in int variables
            Console.Write("Area of triangle calculator\nEnter the width: ");
            int width = Convert.ToInt32(Console.ReadLine());
            Console.Write("\nEnter the length: ");
            int length = Convert.ToInt32(Console.ReadLine());

            // New int variable calling on area method to calculate using previous input
            int area = Area(length, width);
            // Print out result using string interpolation
            Console.Write($"The area of the triangle is: {area}");

            Console.ReadLine();
        }

        static int Area(int x, int y) // Function to calculate area of a triangle
        {
            return (x * y) / 2;
        }
    }
}
