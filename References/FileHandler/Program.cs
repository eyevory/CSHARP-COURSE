using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileHandler
{
    class FileHandler
    {
        public void WriteToFile(string fileName, string content)
        {
            using (StreamWriter writer = new StreamWriter(fileName))
            {
                writer.WriteLine(content);
            }
        }

        public string ReadFromFile(string fileName)
        {
            using (StreamReader reader = new StreamReader(fileName))
            {
                return reader.ReadToEnd();
            }
        }

        public void AppendToFile(string fileName, string content)
        {
            using(StreamWriter writer = new StreamWriter(fileName, true))
            {
                writer.WriteLine(content);
            }
        }
    }
    
    internal class Program
    {
        static void Main(string[] args)
        {
            FileHandler fileHandler = new FileHandler();

            // Write to file
            string fileName = "example.txt";
            fileHandler.WriteToFile(fileName, "This is the first line");
            // Read from file
            string content = fileHandler.ReadFromFile(fileName);
            Console.WriteLine("File content after writing");
            Console.WriteLine(content);

            // Append to file
            fileHandler.AppendToFile(fileName, "This is an appended line");

            // Read from file again
            content = fileHandler.ReadFromFile(fileName);
            Console.WriteLine("File content after appending:");
            Console.WriteLine(content);
            Console.ReadLine();
        }
    }
}
