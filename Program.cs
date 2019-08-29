using System;

namespace TreasureHunter
{
    class Program
    {
        static void Main(string[] args)
        {
            App app = new App();
            app.DisplayTitle();
            app.Greeting();
            app.Run();
            // app.DisplayHelpInfo();
        }
    }
}
