using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace A._25_Lists_And_Collections_C_
{
    public class Inventory
    {
        // List (somewhat useless since product name is saved in Dictionary as well, although used with .Contain and foreach loops)
        private List<string> items;
        // Dictionary with Key as Product and Value split into two different values called Price and Stock (akin to a tuple)
        private Dictionary<string, (double Price, int Stock)> itemDetails;

        // Constructor for list and dictionary
        public Inventory()
        {
            items = new List<string>();
            itemDetails = new Dictionary<string, (double Price, int Stock)>();
        }
        // Method to add an item to the list and dictionary with price and stock
        public void AddItem(string name, double price, int stock)
        {
            if (items.Contains(name)) // Checks if product to be added already exists
            {
                Console.WriteLine($"{name} already exists");
            }
            else // Add values to list and dictionary
            {
                items.Add(name);
                itemDetails[name] = (price, stock);
            }
        }
        // Method to remove an item, with input being name of item
        public void RemoveItem(string name)
        {
            if (items.Contains(name)) // Checks if the input name exists in list and removes it
            {
                items.Remove(name);
                itemDetails.Remove(name);
                Console.WriteLine($"{name} has been removed from the inventory.");
            }
            else // Prints message in case the product is not found
            {
                Console.WriteLine($"{name} not found");
            }
        }
        // Method to print out full inventory details
        public void DetailsItem()
        {
            Console.WriteLine("Current inventory:");
            foreach (var item in items) // Foreach loop through product name amount in list
            {
                var details = itemDetails[item]; // Sets value of details variable to the product name matching Dictionarys Values of product Key
                Console.Write($"Product: {item} Price: {details.Price}, Stock: {details.Stock}\n"); // Print it out
            }
        }
        // Method to update stock of existing product
        public void UpdateStock(string name, int nstock)
        {
            if (!items.Contains(name)) // Checks if the product does NOT exist
            {
                Console.WriteLine($"Product: {name} not found");
            }
            else 
            {
                var oldPrice = itemDetails[name]; // Gets Values of inputted product Key and stores it in a variable
                itemDetails[name] = (oldPrice.Price, nstock); // Sets said products stock value to the inputted stock value while keeping the price the same
                Console.WriteLine($"Stock of {name} updated to {nstock}."); // Print confirming that it has been done
            }
        }
        // Method to find highest priced product
        public void MostExpensive()
        {
            if (items.Count < 1) // Checks if inventory list has 0 or less products inside
            {
                Console.WriteLine("Inventory is empty.");
            }
            else
            {
                var highest = itemDetails // LINQ to sort dictionary by Price value in descending order, then return the Key + Values of the highest(first) priced product in a variable
                    .OrderByDescending(x => x.Value.Price)
                    .FirstOrDefault();
                var highestItem = highest.Key; // Stores name of product of the highest priced product
                var highestPrice = highest.Value.Price; // Stores value of highest priced product
                Console.WriteLine($"Most expensive item: {highestItem}, Price: {highestPrice}");
            }
        }
        // Method to calculate total value of inventory taking into consideration stock and price
        public void TotalValue()
        {
            if (items.Count > 0) // Checks that the inventory has more than 0 items
            {
                var totalValue = itemDetails.Sum(x => x.Value.Price * x.Value.Stock); // .Sum the dictionary where the Price and Stock are multiplied
                Console.WriteLine($"Total Inventory Value: {totalValue}"); // Print total value
            }
            else // In case inventory is empty
            {
                Console.WriteLine("Inventory is empty.");
            }
        }
    }
    
    
    
    internal class Program
    {
        static void Main(string[] args)
        {
            // Create object named inventory
            Inventory inventory = new Inventory();
            // CurrentCulture to make commas into periods in the double price values
            Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;

            // Call on AddItem method to add to the inventory (name, price, stock)
            inventory.AddItem("Laptop", 1200.50, 7);
            inventory.AddItem("Smartphone", 799.99, 12);
            inventory.AddItem("Tablet", 399.99, 15);
            // Print out current inventory
            inventory.DetailsItem();
            // Update stock (name, stock)
            inventory.UpdateStock("Laptop", 5);
            // Remove item from inventory (name)
            inventory.RemoveItem("Tablet");
            // Find and print highest value item and its value
            inventory.MostExpensive();
            // Calculate total value
            inventory.TotalValue();

            Console.ReadLine();
        }
    }
}
