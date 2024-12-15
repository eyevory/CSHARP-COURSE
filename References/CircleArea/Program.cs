using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CircleArea
{
    class Circle
    {
        private double Radius;
        // Constructor
        public Circle(double radius)
        {
            Radius = radius;
        }
        // Method to calculate 
        public double GetPerimeter()
        {
            return 2 * Math.PI * Radius;
        }
        // Method to calculate area

        public double GetArea()
        {
            return Math.PI * Math.Pow(Radius, 2);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Etner the radius of the circle: ");
            double radius = Convert.ToDouble(Console.ReadLine());

            Circle circle = new Circle(radius);

            double perimeter = circle.GetPerimeter();
            double area = circle.GetArea();

            Console.WriteLine($"The perimeter of the circle is: {perimeter:F2}");
            Console.WriteLine($"The area of the circle is: {area:F2}");

            Console.ReadLine();
        }
    }
}
