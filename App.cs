using System;
using System.Linq;
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
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Press any key to start or Ctrl+C to exit.");
            Console.ResetColor();
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
            // Sound effects
            // Console.Beep(1500, 5000);
            // Typewrite("WAKE UP!! GET UP!!! ");
            // Typewrite("GET ON YOUR FEET NOW!!!\n");
            Console.WriteLine("================================================================================\n");
            Console.WriteLine("You slowly gain consciousness and your blurred vision starts to focus as you groggily look around. You see dead crew members strewn about the room.\nSparks fly from various consoles. The ringing in your ears starts to lessen and is replaced by the ship's AI repeating -\n");
            Console.ReadKey();
            Console.ForegroundColor = ConsoleColor.Yellow;
            Typewrite("\"Ship is in critical condition. Hostile life forms on board. Please head to the escape pods.\"");
            Console.ResetColor();
            Console.WriteLine("------------------------------------------------------\n");

            // NOTE Think of a better scenario to ask name.
            Player.GetPlayerName();
            Console.Clear();
        }

        public void Setup()
        {
            Player.Inventory.Clear();

            // NOTE Implement others after you finish requirements.
            Boundary cafeteria = new Boundary("Cafeteria", "Your adrenaline kicks in and you jolt up. Taking a quick assesment of the room you see the entry to the hallway. By the entrance you see the ship's doctor motionless under debris.");
            cafeteria.AltDescription = "You do another scan of the cafeteria. There's nothing else here for you. You hear an explosion nearby. You have to get to the escape pods!";
            Boundary doctor = new Boundary("Doctor", "You rush to the doctor and check her pulse. Nothing. You start to tear at the debris on top of her to attempt CPR but discover she's been impaled as you lift the last piece of debris.\nIn both her hands you notice some nylocloth and a vial of chlorogen. Her failed attempt to alleviate the pain.");
            doctor.AltDescription = "You check the doctor again. There's nothing you can do for her. You hear an explosion nearby. You have to get to the escape pods!";
            Boundary hallway = new Boundary("Hallway", "You burst into the hallway. You can run directly to the Escape Port, check the Engineering room, or go back to the Cafeteria.");
            // NOTE Maybe add the losing scenario in the Engineering Room. Add alien encounter.
            Boundary engineering = new Boundary("Engineering", "You enter the Engineering room and see an Anti-Matter Torch in the hands of a dead crew member.");
            // NOTE Still want to add an alien encounter in the Port.
            Boundary port = new Boundary("Port", "You reach the Escape Port entry and frantically hit the button to open the door. No response. You try to pry the doors open with your fingers but they don't budge. If only you could cut through the door somehow.");
            port.AltDescription = "You use the torch to cut through the entry, pull the doors apart, and fall into the Escape Port. You rush to an escape pod, jump in, and hit the launch sequence.\nThe pod blasts through the open hatch and sends you to a safe distance. You watch the once mighty ship, The Venator, explode as you head towards the nearest planet. Alone...";
            // Boundary hololift = new Boundary("Hololift", "Used to move to different levels of the ship.");

            Item torch = new Item("Torch", "Used to splice tools or cut through heavy metals.");
            Item nylocloth = new Item("Nylocloth", "Durable yet flexible material. Used often for clothing.");
            Item chlorogen = new Item("Chlorogen", "Extremely potent anesthesia. Most commonly used in medical procedures. Use caution due to potency.");
            Item eek = new Item("Equalizer", "Rapid-firing blaster. Nicknamed 'Eek' due to the high-pitched 'Eee' sound it makes when you hold down the trigger.");

            cafeteria.AddNeighborBoundary(hallway);
            cafeteria.AddNeighborBoundary(doctor);
            hallway.AddNeighborBoundary(engineering);
            hallway.AddNeighborBoundary(port);

            engineering.Items.Add(torch);
            doctor.Items.Add(nylocloth);
            doctor.Items.Add(chlorogen);

            Location = cafeteria;
        }

        public void Run()
        {
            DisplayTitle();
            Greeting();
            while (Playing)
            {
                DisplayMenu();
            }
        }

        public void CaptureUserInput()
        {
            // NOTE Blows up if you just do a space and a blank line after hitting enter.
            Console.WriteLine("------------------------------------------------------\n");
            Console.WriteLine("Type 'help' to display list of commands.");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("What do you do: ");
            Console.ResetColor();
            string userInput = Console.ReadLine().ToLower();
            string[] words = userInput.Split(' ');
            string command = words[0];
            string option = "";

            if (words.Length > 1)
            {
                // NOTE Still blew up when entering just a space
                // if (words[1] is null)
                // {
                //     Console.WriteLine("Please enter the correct location or item.");
                // }
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
                    Console.Clear();
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
                    Quit();
                    break;
                default:
                    Console.WriteLine("Invalid option\n");
                    break;
            }
        }

        public void Quit()
        {
            Console.Clear();
            Console.WriteLine($"You curl up into the fetal position and start to sob uncontrollably as the deafening explosions continue around you.\nYou've heard of the cunning Warpmancers and their vastly advanced technology but your hubris as a young captain has led you and your crew to a ruthless fate.\nAt least you can go down in history as Captain {Player.Name}. The first man to experience how fast a dreadnought class ship could be turned into space dust.");
            Playing = false;
        }

        public void Replay()
        {
            Console.WriteLine("");
            Console.WriteLine($"Thanks for playing {Player.Name}! Would you like to play again? Y/N");
            string playAgain = Console.ReadLine().ToUpper();
            if (playAgain == "Y")
            {
                Console.Clear();
                Setup();
                Run();
            }
            if (playAgain == "N")
            {
                Playing = false;
            }
        }

        public void ChangeLocation(string locationName)
        {
            // TODO  Need to handle Cafeteria and Doctor backtracking story. Use AltDescription. Look into IsLosable prop for Boundary.
            IItem portItem = Player.Inventory.Find(i => i.Name.ToLower() == "torch");
            if (Player.Inventory.Contains(portItem) && locationName == "Port")
            {
                Location = Location.NeighborBoundaries[locationName];
                Console.Clear();
                Console.WriteLine(Location.AltDescription);
                Console.ReadKey();
                Replay();
                return;
            }

            if (locationName == "")
            {
                Console.WriteLine("Please enter the correct location.\n");
            }
            if (Location.NeighborBoundaries.ContainsKey(locationName))
            {
                Location = Location.NeighborBoundaries[locationName];
                // Console.ReadKey();
                // Console.Clear();
            }
        }

        public void DisplayHelpInfo()
        {
            Console.Clear();
            Console.WriteLine("================================================================================\n");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("The goal of the game is to get to the escape pods and escape the exploding ship.\n");
            Console.ResetColor();
            Console.WriteLine("================================================================================\n");
            Console.WriteLine("Type the below commands to progress through the game.");
            Console.WriteLine("------------------------------------------------------\n");
            Console.WriteLine("'Look' - Displays room description.\n");
            Console.WriteLine("'Go <Location>' - Moves you to your desired location.\n");
            Console.WriteLine("'Take <ItemName>' - Adds the item to your inventory.\n");
            Console.WriteLine("'Inventory' - Displays a list of your inventory.\n");
            Console.WriteLine("'Help' - Displays the list of commands.\n");
            Console.WriteLine("'Quit' - Quits the game.\n");
            Console.WriteLine("------------------------------------------------------\n");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Press any key to go back.");
            Console.ResetColor();
            Console.ReadKey();
            Console.Clear();
        }

        public void DisplayMenu()
        {
            Console.WriteLine("================================================================================\n");
            Console.WriteLine($"{Location.Description}\n");
            Console.WriteLine("================================================================================\n");
            CaptureUserInput();
            return;
        }

        public void DisplayPlayerInventory()
        {
            // NOTE Bummer... Really want to use this...
            // Player.Inventory.ForEach(Console.WriteLine);
            Console.Clear();
            Console.WriteLine("================================================================================\n");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine($"{Player.Name}'s Inventory\n");
            Console.ResetColor();
            Console.WriteLine("================================================================================\n");
            if (!Player.Inventory.Any())
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("You do not have any items.");
                Console.ResetColor();
            }
            Console.ForegroundColor = ConsoleColor.Cyan;
            foreach (var item in Player.Inventory)
            {
                Console.WriteLine($"{item.Name} - {item.Description}\n");
            }
            Console.ResetColor();
            Console.WriteLine("");
            // Console.WriteLine("================================================================================\n");
            Console.WriteLine("--------------------------------------------------------------------------------\n");
            // NOTE Can set to be able to use items later on.
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Press any key to go back.");
            Console.ResetColor();
            Console.ReadKey();
            Console.Clear();
        }

        public void DisplayRoomDescription()
        {
            Console.Clear();
            Console.WriteLine("================================================================================\n");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine($"You are at the {Location.Name}.");
            Console.ResetColor();
            Console.WriteLine("================================================================================\n");
            Console.WriteLine("------------------------------------------------------\n");
            if (Location.Name == "Port")
            {
                Console.WriteLine($"{Location.AltDescription}\n");
            }
            else
            {
                Console.WriteLine($"{Location.Description}\n");
            }
            Console.WriteLine("------------------------------------------------------\n");
            Console.WriteLine($"You can 'go' to these locations:");
            Location.DisplayNeighborBoundaries();
            Console.WriteLine("");
            if (Location.Items.Any())
            {
                Console.WriteLine($"You can 'take' these items:");
                Location.DisplayLocationItems();
                Console.WriteLine("");
            }
            Console.WriteLine("------------------------------------------------------\n");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Press any key to go back.");
            Console.ResetColor();
            Console.ReadKey();
            Console.Clear();
        }

        public void TakeItem(string item)
        {
            // NOTE Error if user enters a space after using take option
            IItem targetItem = Location.Items.Find(i => i.Name.ToLower() == item.ToLower());
            if (targetItem is null)
            {
                Console.WriteLine("This item doesn't exist.");
                return;
            }

            if (Location.Items.Contains(targetItem))
            {
                Player.Inventory.Add(targetItem);
                Console.WriteLine($"You acquired {targetItem.Name}!");
                Console.ReadKey();
                Console.Clear();
            }
        }

        public App()
        {
            Player = new Player();
            Playing = true;
        }
    }
}