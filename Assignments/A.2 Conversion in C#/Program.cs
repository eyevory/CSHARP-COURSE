using System;

namespace ConversionTaskInCSHARP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Declare string variable with numerical value
            string numString = "41";
            // Convert string value to new int variable
            int num = int.Parse(numString);
            // Write out converted int variable
            Console.WriteLine(num);

            Console.ReadKey();
        }
    }
}
