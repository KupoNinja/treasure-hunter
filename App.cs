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
            Console.ReadKey();
            Typewrite("\"Ship is in critical condition. Hostile life forms on board. Please head to the escape pods.\"");
            Console.WriteLine("------------------------------------------------------\n");

            // NOTE Think of a better scenario to ask name.
            Player.GetPlayerName();
            // NOTE Should I have this here?
            Console.Clear();
        }

        public void Setup()
        {
            // NOTE Implement others after you finish requirements.
            // TODO Change the Descriptions to the scenario.
            Boundary cafeteria = new Boundary("Cafeteria", "You woke up in the cafeteria. There are dead crew members strewn about the room.\nYou see the entry to the hallway.");
            Boundary hallway = new Boundary("Hallway", "You burst into the hallway. You can run directly to the Escape Port, check the Engineering room, or go back to the Cafeteria.");
            Boundary engineering = new Boundary("Engineering", "You enter the Engineering room and see an Anti-Matter Torch in the hands of a dead crew member.");
            Boundary port = new Boundary("Port", "You reach the Escape Port entry and frantically hit the button to open the door. No response. You try to pry the doors open with your fingers but they don't budge. If only you could cut through the door somehow.");
            // Boundary hololift = new Boundary("Hololift", "Used to move to different levels of the ship.");

            Item torch = new Item("Torch", "Used to splice tools or cut through heavy metals.");
            Item nylocloth = new Item("Nylocloth", "Durable yet flexible material. Used often for clothing.");
            // Item chlorogen = new Item("Chlorogen", "Extremely potent anesthesia. Most commonly used in medical procedures. Use caution due to potency.");
            Item eek = new Item("Equalizer", "Rapid-firing blaster. Nicknamed 'Eek' due to the high-pitched 'Eee' sound it makes when you hold down the trigger.");

            cafeteria.AddNeighborBoundary(hallway);
            hallway.AddNeighborBoundary(engineering);
            hallway.AddNeighborBoundary(port);

            engineering.Items.Add(torch);

            // NOTE Take these out when done testing.
            Player.Inventory.Add(nylocloth);
            // Player.Inventory.Add(eek);

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
            Console.WriteLine("------------------------------------------------------\n");
            // NOTE Take this out after finishing ChangeLocation()
            Console.WriteLine(Location.Name);
            foreach (var kvp in Location.NeighborBoundaries)
            {
                Console.WriteLine(kvp.Key);
            }

            Console.WriteLine("Type 'help' to display list of commands.");
            Console.Write("What do you do: ");
            string userInput = Console.ReadLine().ToLower();
            string[] words = userInput.Split(' ');
            string command = words[0];
            string option = "";

            if (words.Length > 1)
            {
                string firstLetter = words[1][0].ToString().ToUpper();
                option = firstLetter + words[1].Substring(1);
            }
            switch (command)
            {
                case "look":
                    DisplayRoomDescription();
                    break;
                case "go":
                    ChangeLocation(option);
                    break;
                case "take":
                    TakeItem(option);
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
            // NOTE Need to handle the repeating dialogue. Need a console clear somewhere.
            if (locationName == "")
            {
                Console.WriteLine("Please enter the correct location.\n");
            }
            if (Location.NeighborBoundaries.ContainsKey(locationName))
            {
                Console.WriteLine(Player.Name);
                Location = Location.NeighborBoundaries[locationName];
                Console.WriteLine(Location.Name);
                Console.ReadKey();
            }

            IItem targetItem = Player.Inventory.Find(i => i.Name.ToLower() == "torch");
            if (Player.Inventory.Contains(targetItem) && locationName == "Port")
            {
                string ending = "You use the torch to cut through the entry, pull the doors apart, and fall into the Escape Port. You rush to an escape pod, jump in, and hit the launch sequence.\nThe pod blasts through the open hatch and sends you to a safe distance. You watch the once mighty ship, The Venator, explode as you head towards the nearest planet. Alone...";
                Location = Location.NeighborBoundaries[locationName];
                Location.Description = ending;
                Console.WriteLine(Location.Description);
                Console.ReadKey();
                // Console.Clear();
                Console.WriteLine("");
                Console.WriteLine("Thanks for playing! Would you like to play again? Y/N");
                string playAgain = Console.ReadLine();
                if (playAgain == "Y")
                {
                    Setup();
                    Run();
                }
                if (playAgain == "N")
                {
                    Playing = false;
                }
            }
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
            Console.WriteLine("------------------------------------------------------\n");
            Console.WriteLine("Press enter to go back.");
            Console.ReadLine();
            Console.Clear();
        }

        public void DisplayMenu()
        {
            Console.WriteLine(Location.Description);
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
            Console.Clear();
        }

        // NOTE Wondering if this is necessary with how I've built this out now.
        public void DisplayRoomDescription()
        {
            Console.Clear();
            Console.WriteLine(Location.Description);
            Console.WriteLine("Press enter to go back.");
            Console.ReadLine();
            Console.Clear();
        }

        public void TakeItem(string item)
        {
            Console.WriteLine(Location.Items[0].Name);
            IItem targetItem = Location.Items.Find(i => i.Name.ToLower() == item);
            if (Location.Items.Contains(targetItem))
            {
                Player.Inventory.Add(targetItem);
                Console.WriteLine($"You acquired {targetItem.Name}!");
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("That item isn't in here.");
            }
        }

        public App()
        {

            Player = new Player();
            Playing = true;
        }
    }
}