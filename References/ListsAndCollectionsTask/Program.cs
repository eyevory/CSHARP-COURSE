using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListsAndCollectionsTask
{
    public class Inventory
    {
        // Private list to store the names of all items
        private List<string> items = new List<string>();

        // Private dictionary to store item details
        // Each key is the item's name, and the value is a tuple containing the price and quantity
        private Dictionary<string, (double price, int stock)> itemDetails = new Dictionary<string, (double price, int stock)>();

        // Method to add a new item to the inventory
        public void AddItem(string name, double price, int stock)
        {
            // Add the items name to the list of items
            items.Add(name);
            // Add or update the item details in the dictionary
            itemDetails[name] = (price, stock);
        }

        // Method to remove an item from the inventory
        public void RemoveItem(string name)
        {
            // Attempt to remove the item from the list of items
            if (items.Remove(name))
            {
                itemDetails.Remove(name);
                Console.WriteLine($"{name} has been removed from the inventory.");
            }
            else
            {
                // If the item doesn't exist notify the user
                Console.WriteLine($"{name} does not exist in the inventory");
            }
        }

        // Method to update the stock of a specific item
        public void UpdateStock(string name, int newStock)
        {
            // Check if the item exists in the dictionary
            if (itemDetails.TryGetValue(name, out var details))
            {
                // Update the stock value while keeping the price unchanged
                itemDetails[name] = (details.price, newStock);
                Console.WriteLine($"Stock of {name} updated to {newStock}");
            }
            else
            {
                // If the item doesn't exist, notify the user
                Console.WriteLine($"{name} is not in inventory currently");
            }
        }

        // Method to retrieve and print all items along with their details
        public void PrintAllItems()
        {
            Console.WriteLine("Current inventory:");

            // Loop through all items and print them out
            foreach(var item in items)
            {
                var details = itemDetails[item];
                Console.WriteLine($"Product: {item}, Price: {details.price}, Stock: {details.stock}");
            }
        }

        // Method to find and print the most expensive item in the inventory
        public void PrintMostExpensiveItem()
        {
            string expensiveItem = null; // Variable to store the name of the most expensive item
            double highestPrice = 0; // Variable to store the highest price found

            // Loop through all items to find the one with highest value
            foreach(var item in items)
            {
                var details = itemDetails[item];
                if(details.price > highestPrice)
                {
                    highestPrice = details.price;
                    expensiveItem = item;
                }
            }
            // If an expensive item was found, print the details
            if(expensiveItem != null)
            {
                Console.WriteLine($"Most expensive item: {expensiveItem}, Price: {highestPrice}");
            }
            else
            {
                // If no items exist in the inventory notify the user
                Console.WriteLine("No items in inventory");
            }
        }
        // Method to find out and print the total value of all items and stock
        public void PrintTotalInventoryValue()
        {
            double totalValue = 0; // Variable to accumulate the total inventory value

            // Loop through all items and calculate their total value (price * stock)
            foreach (var item in items)
            {
                var details = itemDetails[item];
                totalValue += details.price * details.stock;
            }
            // Print the total value of the inventory
            Console.WriteLine($"Total inventory value: {totalValue}");
        }
    }
    
    
    
    internal class Program
    {
        static void Main(string[] args)
        {
            // Create an instance of the inventory class
            Inventory inventory = new Inventory();

            // Add product to the inventory
            inventory.AddItem("Laptop", 1200.50, 7);
            inventory.AddItem("Smartphone", 799.99, 12);
            inventory.AddItem("Tablet", 399.99, 15);

            // Print all the current items and their details
            inventory.PrintAllItems();

            // Update the stock quantity of Laptop
            inventory.UpdateStock("Laptop", 5);

            // Remove the Tablet from the inventory
            inventory.RemoveItem("Tablet");

            // Print the most expensive item in the inventory
            inventory.PrintMostExpensiveItem();

            // Print the total value of the inventory
            inventory.PrintTotalInventoryValue();
            Console.WriteLine("Press any key to continue . . .");
            Console.ReadLine();
        }
    }
}
