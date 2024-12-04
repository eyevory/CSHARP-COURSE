using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassConstructor
{
    class Person
    {
        // Properties of the class
        public string Name { get; set; }

        public int Age { get; set; }

        // Constructor to initialize Name and Age
        public Person(string name, int age)
        {
            Name = name;
            Age = age;
        }

        // Method to display details
        public void DisplayInfo()
        {
            Console.WriteLine($"Name: {Name}, Age: {Age}");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            // Create an instance of the Class "Person" using the constructor
            Person person = new Person("Bob", 37);
            // Call the method to display the person info
            person.DisplayInfo();


            Console.ReadLine();
        }
    }
}
