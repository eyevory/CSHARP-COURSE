using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A._20_Area_of_Circle_Calculation_Task_in_C_
{
    public class Circle
    {
        // Class properties
        public double Radius { get; set; }
        // Constructor to initialize Radius
        public Circle(double radius)
        {
            Radius = radius;
        }
        // Method to calculate circle area
        public double CalculateArea()
        {
            return Math.PI * Radius * Radius;
        }
    }
    
    internal class Program
    {
        static void Main(string[] args)
        {
            // Create instance of Circle using constructor with radius of 1.5
            Circle circle = new Circle(1.5);
            // Call method to calculate circle area and store in double
            double area = circle.CalculateArea();
            // Print answer
            Console.WriteLine($"Area of the circle is: {area}");


            Console.ReadLine();
        }
    }
}
