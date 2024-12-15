using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassFieldsAssignment
{
    class Product
    {
        // Private fields to store product with name, price and quantity
        private string Name;
        private double Price;
        private int Stock;

        // Constructor
        public Product(string name, double price, int stock)
        {
            this.Name = name; // Assign the product name
            SetPrice(price); // Validate and set the product price
            SetStock(stock); // Validate and set the stock quantity

        }

        // Method to set the name of the product
        public void SetName(string name)
        {
            // Assign a valid name or default to "Invalid name" ir input is null or empty
            this.Name = !string.IsNullOrEmpty(Name) ? Name : "Invalid Name";
        }

        // Method to get the name of the product
        public string GetName()
        {
            // Return the name of the product
            return Name;
        }
        // Method to set the price of the product
        public void SetPrice(double price)
        {
            // Assign a positive price or default to 0 if input is invalid
            this.Price = price > 0 ? price : 0;
        }
        // Method to get the price of the product
        public double GetPrice()
        {
            // Return the price of the product
            return Price;
        }
        // Method to set the quantity of the product in stock
        public void SetStock(int stock)
        {
            // Assign a non negative value or default to 0 if invalid input
            this.Stock = stock >= 0 ? stock : 0;
        }
        // Method to get the quantity of the product in stock
        public int GetStock()
        {
            // Return the stock quantity
            return Stock;
        }

        // Method to return the details of the product
        public string ReturnDetails()
        {
            // Return the details about the product "Name, price, stock"
            return $"Name: {Name}\nPrice: {Price}$\nStock: {Stock}";
        }
    }
    
    internal class Program
    {
        static void Main(string[] args)
        {
            // Create an instance of the product class
            Product product = new Product("Laptop", 999.99, 20);

            Console.WriteLine(product.ReturnDetails());
            // Update product details
            product.SetName("Smartphone");
            product.SetPrice(599.99);
            product.SetStock(20);

            // Display product details
            Console.WriteLine(product.ReturnDetails());

            Console.ReadLine();

        }
    }
}
