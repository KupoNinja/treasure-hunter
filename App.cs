using System;
using TreasureHunter.Interfaces;
using TreasureHunter.Models;

namespace TreasureHunter
{
    public class App : IApp
    {
        public IPlayer Player { get; set; }
        public IBoundary Location { get; set; }
        public bool Playing { get; set; }

        public void CaptureUserInput()
        {

        }

        public void ChangeLocation()
        {

        }

        public void DisplayHelpInfo()
        {
            Console.Clear();
            Console.WriteLine("-Type the below commands to progress through the game.\n");
            Console.WriteLine("'Look' - Displays room description.\n");
            Console.WriteLine("'Go <Direction>' - Moves you to an adjacent room.\n");
            Console.WriteLine("'Take <ItemName>' - Adds the item to your inventory.\n");
            Console.WriteLine("'Inventory' - Displays a list of your inventory.\n");
            Console.WriteLine("'Help' - Displays the list of commands.\n");
            Console.WriteLine("'Quit' - Quits the game.\n");

            Console.WriteLine("Press enter to go back.");
            Console.ReadLine();
        }

        public void DisplayMenu()
        {

        }

        public void DisplayPlayerInventory()
        {

        }

        public void DisplayRoomDescription()
        {

        }

        public void Greeting()
        {

        }

        public void Run()
        {

        }

        public void Setup()
        {

        }

        public void TakeItem()
        {

        }

        public App()
        {
            Playing = true;
        }
    }
}