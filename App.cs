using System;
using System.Threading;
using TreasureHunter.Interfaces;
using TreasureHunter.Models;

namespace TreasureHunter
{
    public class App : IApp
    {
        public IPlayer Player { get; set; }
        public IBoundary Location { get; set; }
        public bool Playing { get; set; }

        public void DisplayTitle()
        {
            Console.Clear();
            Console.WriteLine("=====================================================================================================================================================");
            string title = @"
     ▄▄▄▄▄▄▄▄▄▄▄  ▄         ▄  ▄▄▄▄▄▄▄▄▄▄▄       ▄               ▄  ▄▄▄▄▄▄▄▄▄▄▄  ▄▄        ▄  ▄▄▄▄▄▄▄▄▄▄▄  ▄▄▄▄▄▄▄▄▄▄▄  ▄▄▄▄▄▄▄▄▄▄▄  ▄▄▄▄▄▄▄▄▄▄▄ 
    ▐░░░░░░░░░░░▌▐░▌       ▐░▌▐░░░░░░░░░░░▌     ▐░▌             ▐░▌▐░░░░░░░░░░░▌▐░░▌      ▐░▌▐░░░░░░░░░░░▌▐░░░░░░░░░░░▌▐░░░░░░░░░░░▌▐░░░░░░░░░░░▌
     ▀▀▀▀█░█▀▀▀▀ ▐░▌       ▐░▌▐░█▀▀▀▀▀▀▀▀▀       ▐░▌           ▐░▌ ▐░█▀▀▀▀▀▀▀▀▀ ▐░▌░▌     ▐░▌▐░█▀▀▀▀▀▀▀█░▌ ▀▀▀▀█░█▀▀▀▀ ▐░█▀▀▀▀▀▀▀█░▌▐░█▀▀▀▀▀▀▀█░▌
         ▐░▌     ▐░▌       ▐░▌▐░▌                 ▐░▌         ▐░▌  ▐░▌          ▐░▌▐░▌    ▐░▌▐░▌       ▐░▌     ▐░▌     ▐░▌       ▐░▌▐░▌       ▐░▌
         ▐░▌     ▐░█▄▄▄▄▄▄▄█░▌▐░█▄▄▄▄▄▄▄▄▄         ▐░▌       ▐░▌   ▐░█▄▄▄▄▄▄▄▄▄ ▐░▌ ▐░▌   ▐░▌▐░█▄▄▄▄▄▄▄█░▌     ▐░▌     ▐░▌       ▐░▌▐░█▄▄▄▄▄▄▄█░▌
         ▐░▌     ▐░░░░░░░░░░░▌▐░░░░░░░░░░░▌         ▐░▌     ▐░▌    ▐░░░░░░░░░░░▌▐░▌  ▐░▌  ▐░▌▐░░░░░░░░░░░▌     ▐░▌     ▐░▌       ▐░▌▐░░░░░░░░░░░▌
         ▐░▌     ▐░█▀▀▀▀▀▀▀█░▌▐░█▀▀▀▀▀▀▀▀▀           ▐░▌   ▐░▌     ▐░█▀▀▀▀▀▀▀▀▀ ▐░▌   ▐░▌ ▐░▌▐░█▀▀▀▀▀▀▀█░▌     ▐░▌     ▐░▌       ▐░▌▐░█▀▀▀▀█░█▀▀ 
         ▐░▌     ▐░▌       ▐░▌▐░▌                     ▐░▌ ▐░▌      ▐░▌          ▐░▌    ▐░▌▐░▌▐░▌       ▐░▌     ▐░▌     ▐░▌       ▐░▌▐░▌     ▐░▌  
         ▐░▌     ▐░▌       ▐░▌▐░█▄▄▄▄▄▄▄▄▄             ▐░▐░▌       ▐░█▄▄▄▄▄▄▄▄▄ ▐░▌     ▐░▐░▌▐░▌       ▐░▌     ▐░▌     ▐░█▄▄▄▄▄▄▄█░▌▐░▌      ▐░▌ 
         ▐░▌     ▐░▌       ▐░▌▐░░░░░░░░░░░▌             ▐░▌        ▐░░░░░░░░░░░▌▐░▌      ▐░░▌▐░▌       ▐░▌     ▐░▌     ▐░░░░░░░░░░░▌▐░▌       ▐░▌
          ▀       ▀         ▀  ▀▀▀▀▀▀▀▀▀▀▀               ▀          ▀▀▀▀▀▀▀▀▀▀▀  ▀        ▀▀  ▀         ▀       ▀       ▀▀▀▀▀▀▀▀▀▀▀  ▀         ▀";
            Console.WriteLine(title);
            Console.WriteLine("=====================================================================================================================================================");

            Console.WriteLine("");
            Console.WriteLine("Press any key to start or Ctrl+C to exit.");
            Console.ReadKey();
        }

        private static void Typewrite(string message)
        {
            for (int i = 0; i < message.Length; i++)
            {
                Console.Write(message[i]);
                Thread.Sleep(50);
            }
            Console.WriteLine("");
        }

        public void Greeting()
        {
            // NOTE Add delays and "sound effects"
            Console.Clear();
            // Typewrite("WAKE UP!! GET UP!!! ");
            // Typewrite("GET ON YOUR FEET NOW!!!\n");
            Console.WriteLine("You slowly gain consciousness and your blurred vision starts to focus as you groggily look around. You see dead crew members strewn about the room.");
            Console.WriteLine("Sparks fly from various consoles.");
            Console.WriteLine("The ringing in your ears starts to lessen and is replaced by the ship's AI repeating -\n");
            Typewrite("\"Ship is in critical condition. Hostile life forms on board. Please head to the escape pods.\"");

            // NOTE Think of a better scenario to ask name.
            Player.GetPlayerName();
        }

        public void Setup()
        {
            // NOTE Implement others after you finish requirements.
            // TODO Change the Descriptions to the scenario.
            Boundary cafeteria = new Boundary("Cafeteria", "Where crew members can relax, socialize, and eat meals specially made by the lovable chef.");
            Boundary hallway = new Boundary("Hallway", "Connects the different rooms and provides access to the hololift.");
            Boundary engineering = new Boundary("Engineering", "Holds the drive core and controls for energy that powers the ship.");
            Boundary escape = new Boundary("Escape Port", "Holds the limited amount of escape pods on the ship.");
            // Boundary hololift = new Boundary("Hololift", "Used to move to different levels of the ship.");

            Item torch = new Item("Anti-Matter Torch", "Used to splice tools or cut through heavy metals.");
            Item nylocloth = new Item("Nylocloth", "Durable yet flexible material. Used often for clothing.");
            // Item chlorogen = new Item("Chlorogen", "Extremely potent anesthesia. Most commonly used in medical procedures. Use caution due to potency.");
            Item eek = new Item("Equalizer", "Rapid-firing blaster. Nicknamed 'Eek' due to the high-pitched 'Eee' sound it makes when you hold down the trigger.");

            cafeteria.AddNeighborBoundary(hallway);
            hallway.AddNeighborBoundary(engineering);
            hallway.AddNeighborBoundary(escape);

            engineering.Items.Add(torch);

            Player.Inventory.Add(nylocloth);
            Player.Inventory.Add(eek);

            Location = cafeteria;
        }

        public void Run()
        {
            Greeting();
            while (Playing)
            {
                DisplayMenu();
            }
        }

        public void CaptureUserInput()
        {
            Console.WriteLine("Type 'help' to display list of commands.");
            Console.Write("What do you do: ");
            string userInput = Console.ReadLine().ToLower();
            string[] words = userInput.Split(' ');
            string command = words[0];
            string option = "";

            if (words.Length > 1)
            {
                option = words[1];
            }
            switch (command)
            {
                case "look":
                    DisplayRoomDescription();
                    break;
                case "go":
                    ChangeLocation(option);
                    break;
                case "inventory":
                    DisplayPlayerInventory();
                    break;
                case "help":
                    DisplayHelpInfo();
                    break;
                case "quit":
                    // NOTE Maybe set up a quit "cutscene"
                    Console.WriteLine("Bye " + Player.Name);
                    Console.ReadKey();
                    Playing = false;
                    break;
                default:
                    Console.WriteLine("Invalid option");
                    break;
            }
        }

        public void ChangeLocation(string locationName)
        {
            // NOTE Start here
            // Boundary destination = (Boundary)locationName;
            // Location = locationName;
        }

        public void DisplayHelpInfo()
        {
            Console.Clear();
            Console.WriteLine("The goal of the game is to get to the escape pods and escape the exploding ship.");
            Console.WriteLine("================================================================================\n");
            Console.WriteLine("-Type the below commands to progress through the game.");
            Console.WriteLine("------------------------------------------------------\n");
            Console.WriteLine("'Look' - Displays room description.\n");
            Console.WriteLine("'Go <Location>' - Moves you to your desired location.\n");
            Console.WriteLine("'Take <ItemName>' - Adds the item to your inventory.\n");
            Console.WriteLine("'Inventory' - Displays a list of your inventory.\n");
            Console.WriteLine("'Help' - Displays the list of commands.\n");
            Console.WriteLine("'Quit' - Quits the game.\n");

            Console.WriteLine("Press enter to go back.");
            Console.ReadLine();
        }

        public void DisplayMenu()
        {
            CaptureUserInput();
            return;
        }

        public void DisplayPlayerInventory()
        {
            // NOTE Bummer... Really want to use this...
            // Player.Inventory.ForEach(Console.WriteLine);
            Console.Clear();
            Console.WriteLine("================================================================================\n");
            foreach (var item in Player.Inventory)
            {
                Console.WriteLine($"{item.Name} - {item.Description}\n");
            }
            Console.WriteLine("");
            Console.WriteLine("================================================================================\n");
            // NOTE Can set to be able to use items later on.
            Console.WriteLine("Press enter to go back.");
            Console.ReadLine();
        }

        public void DisplayRoomDescription()
        {
            Console.WriteLine(Location.Description);
        }

        public void TakeItem()
        {

        }

        public App()
        {
            Player = new Player();
            Playing = true;
        }
    }
}