using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_6
{
    class Game
    {
        // Class fields and properties
        public string Name { get; private set; }
        public string Publisher { get; private set; }
        public string Year { get; private set; }
        public string Genre { get; private set; }
        // Constructor to initialize properties
        public Game(string name, string publisher, string year, string genre)
        {
            Name = name;
            Publisher = publisher;
            Year = year;
            Genre = genre;
        }
        // Method to print out input list
        public void DisplayInformatiom(List<Game> list)
        {
            foreach (var g in list)
            {
                Console.WriteLine($"Game: {g.Name} - Publisher: {g.Publisher} - Release Year: {g.Year} - Genre: {g.Genre}");
            }
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            // New "Game" instance with input
            Game listAdd = new Game("Bloons 6", "Ninja Kiwi", "2018", "Tower Defense");
            // Create list with Game instance input
            List<Game> game = new List<Game>{listAdd};
            // Create another instance to store values
            Game listAdd2 = new Game("Counter-Strike Source", "Valve", "2004", "Tactical Shooter");
            // Add them to list
            game.Add(listAdd2);
            // Call method to display list
            listAdd.DisplayInformatiom(game);

            Console.ReadLine();



            // Useless code
            /*
            List<Game> games2 = new List<Game>() {Name = "Bloons 6", "Ninja Kiwi", "2018", "Tower Defense" };
            game.Add( new List<Game>(){ Name = "Bloons 6", Publisher = "Ninja Kiwi", Year = "2018", Genre = "Tower Defense"});
            game.Add(Tuple.Create("Counter-Strike Source", "Valve", "2004", "Tactical Shooter"));

            var game = new List<(string Name, string Publisher, string Year, string Genre)>
            {
                ("Counter-Strike Source", "Valve", "2004", "Tactical Shooter")
            };
            */
        }
    }
}
