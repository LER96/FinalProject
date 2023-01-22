using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject
{
    class GameEngine
    {
        public void Start()
        {
            StartMenu();
        }

        public void StartMenu()
        {
            Console.Clear();

            Console.WriteLine("Welcome to the console game engine!");
            Console.WriteLine("Please select an option:");
            Console.WriteLine("1. Create a new tilemap (width, height)");
            Console.WriteLine("2. Run the most recent game");
            Console.WriteLine("3. Load in the most recent saved tilemap");
            Console.Write("Enter your selection: ");

            string input = Console.ReadLine();

            switch (input)
            {
                // Start game engine
                case "1":
                    //Ask the user for the width and height.
                    Console.Write("Enter the width of the tilemap: ");
                    int width = GetValue<int>();
                    Console.Write("Enter the height of the tilemap: ");
                    int height = GetValue<int>();

                    StartGameEngine(width, height);
                    break;

                // Run the game
                case "2":
                    // Insert code to run the most recent game here
                    break;

                // Load the recent saved game engine progress 
                case "3":
                    // Insert code to load the most recent saved tilemap here
                    break;
                default:
                    Console.WriteLine("Invalid selection. Please try again.");
                    break;
            }
        }

        public void StartGameEngine(int width, int height)
        {
            //Clear the console for a fresh TileMap
            Console.Clear();

            //Create the tilemap and draw it on the screen.
            var tilemap = new Grid(width, height);
            //tilemap.Draw();

            var input = RefreshGameEngineUI(tilemap);

            while (true)
            {
                switch (input)
                {
                    // Start game engine
                    case "1":
                        // Insert code for selecting a tile space
                        //Ask the user for the x and y.
                        Console.Write("Enter the x of the tilemap: ");
                        int x = GetValue<int>();
                        Console.Write("Enter the y of the tilemap: ");
                        int y = GetValue<int>();

                        //tilemap.SelectTileSpace(x, y);
                        input = RefreshGameEngineUI(tilemap);

                        break;
                    case "2":
                        //tilemap.DeselectTileSpace();
                        input = RefreshGameEngineUI(tilemap);
                        break;
                    case "3":
                        Console.Write("Enter the icon of the tileobject: ");
                        string iconObject = Console.ReadLine();
                        Console.Write("Enter the color of the tileobject (Yellow, Green or Blue): ");
                        string colorObject = Console.ReadLine();

                        var color = ConsoleColor.White;
                        if (colorObject.ToLower() == "yellow") color = ConsoleColor.Yellow;
                        if (colorObject.ToLower() == "green") color = ConsoleColor.Green;
                        if (colorObject.ToLower() == "blue") color = ConsoleColor.Blue;

                        //tilemap.AddNewTileObject(iconObject, color);
                        input = RefreshGameEngineUI(tilemap);
                        break;
                    case "4":
                        //tilemap.DeleteTileObject();
                        input = RefreshGameEngineUI(tilemap);
                        break;
                    case "5":
                        //tilemap.PlaceTile();
                        input = RefreshGameEngineUI(tilemap);
                        break;
                    case "6":
                        StartMenu();
                        break;
                    default:
                        Console.WriteLine("Invalid selection. Please try again.");

                        break;
                }
            }
        }

        public string RefreshGameEngineUI(Grid tilemap)
        {
            //Clear the console for a fresh TileMap
            Console.Clear();

            //tilemap.Draw();

            //Add game engine options
            Console.WriteLine("Please select an option:");
            Console.WriteLine("1. Select a tile space (x , y)");
            Console.WriteLine("2. Deselect tile space");
            Console.WriteLine("3. Add new object on selected tile (icon, color) *Yellow, Blue or Green");
            Console.WriteLine("4. Delete selected tile object");
            Console.WriteLine("5. Place Tile"); //Add tile properties when placing a tile. Also bring the TileObject over to the new one if it has one.
            Console.WriteLine("6. Back To main menu");
            Console.Write("Enter your selection: ");
            string input = GetValue<string>();

            return input;
        }



        public dynamic GetValue<T>()
        {
            if (typeof(T) == typeof(int))
            {
                return int.Parse(Console.ReadLine());
            }
            else if (typeof(T) == typeof(string))
            {
                return Console.ReadLine();
            }
            else
            {
                return false;
            }
        }

    }


}
