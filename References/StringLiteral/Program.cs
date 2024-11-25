using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringLiteral
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string speech = "He said \"something\"";
            // Pathing
            string path = "C:\\Users\\JavaScriptCode\\Desktop\\C# Course\nNew Line";

            Console.WriteLine(path);
            Console.WriteLine(speech);

            // Pathing version 2
            path = @"C:\Users\JavaScriptCode\Desktop\C# Course" + "\nNew Line";
            Console.WriteLine(path);

            string name = @"Hello ""someone""";
            Console.WriteLine(name);

            name = "Hello 'someone'";
            Console.WriteLine(name);

            Console.ReadLine();
        }
    }
}
