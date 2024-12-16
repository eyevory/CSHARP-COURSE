using System;

class Program
{
    static void Main(string[] args)
    {
        // Try-Catch to deal with invalid input
        try
        {
            // User input stored as string
            Console.Write("Enter the first number: ");
            string input1 = Console.ReadLine();

            Console.Write("Enter the second number: ");
            string input2 = Console.ReadLine();
            // Convert user input to double
            double input1Conv = Convert.ToDouble(input1);
            double input2Conv = Convert.ToDouble(input2);
            // Call methods to do calculations using user input
            double sum = Add(input1Conv, input2Conv);
            double difference = Subtract(input1Conv, input2Conv);
            double product = Multiply(input1Conv, input2Conv);
            double quotient = Divide(input1Conv, input2Conv);
            // Print messages with results
            Console.WriteLine($"The sum of the numbers is: {sum}");
            Console.WriteLine($"The difference of the numbers is: {difference}");
            Console.WriteLine($"The product of the numbers is: {product}");
            Console.WriteLine($"The quotient of the numbers is: {quotient:F2}"); // :F2 limits output to 2 decimals
        }
        catch (FormatException) // If user enters something that cannot be converted to double
        {
            Console.WriteLine("Error: Invalid input (only use numbers)");
        }

        Console.ReadLine();
    }
    // Method to sum numbers
    static double Add(double num1, double num2)
    {
        return num1 + num2;
    }
    // Method to get difference
    static double Subtract(double num1, double num2)
    {
        return num1 - num2;
    }
    // Method to get product
    static double Multiply(double num1, double num2)
    {
        return num1 * num2;
    }
    // Method to divide
    static double Divide(double num1, double num2)
    {
        return num1 / num2; 
    }
}
