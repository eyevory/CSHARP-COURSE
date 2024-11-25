using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace StringLooping
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string message = "C# is fun";

            // Char
            /*
            Console.WriteLine(message[0]); // C
            Console.WriteLine(message[1]); // #
            Console.WriteLine(message[2]); // 
            Console.WriteLine(message[3]); // i
            Console.WriteLine(message[4]); // s
            */

            for(int i = 0; i < message.Length; i++)
            {
                Console.WriteLine(message[i]);
                Thread.Sleep(50);
            }

            Console.WriteLine();
            // Console.WriteLine(message.Contains("C")); // True
            bool contains = false;

            for( int i = 0; i < message.Length; i++)
            {
                if(message[i].Equals('C'))
                { 
                    contains = true;
                    break;
                }
                else
                {
                    contains = false;
                }
            }
            Console.WriteLine(contains);
            Console.ReadLine();
        }
    }
}
