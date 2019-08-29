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