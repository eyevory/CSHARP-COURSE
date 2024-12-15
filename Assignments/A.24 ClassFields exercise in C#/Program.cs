using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace A._24_ClassFields_exercise_in_C_
{
    public class Product // new class named Product
    {
        // declaring private fields for name price and stock
        private string name;

        private double price;

        private int stock;
        // Constructor for name, price and stock
        public Product(string name, double price, int stock)
        {
            this.name = name;
            this.price = price;
            this.stock = stock;
        }

        // Set methods to set a new value for name, price and stock separately
        public void SetName(string newName)
        {
            name = newName;
        }

        public void SetPrice(double newPrice)
        {
            price = newPrice;
        }

        public void SetStock(int newStock)
        {
            stock = newStock;
        }

        // Get methods to return name, price or stock in a product
        public string GetName()
        {
            return name;
        }

        public double GetPrice()
        {
            return price;
        }

        public int GetStock()
        {
            return stock;
        }
        
        // Method to print out details about current product
        public string GetProductDetails()
        {
            return $"Product Name: {name}, Price: {price}, Stock: {stock}";
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            // new product using the Product class and assigning inital values
            Product item = new Product("Phone", 599.99, 5);
            
            // Print initial values set
            Console.WriteLine("Initial product details:");
            Console.WriteLine(item.GetProductDetails());

            // Set new values individually 
            item.SetName("Laptop");
            item.SetPrice(999.99);
            item.SetStock(10);
            
            // Print new values
            Console.WriteLine("Updated product details\n" + item.GetProductDetails());

            Console.WriteLine("\nExample of Get method: " + item.GetName());
            
            Console.ReadLine();
        }
    }
}
