using System;

namespace TreasureHunter
{
    class Program
    {
        static void Main(string[] args)
        {
            App app = new App();
            app.DisplayTitle();
            app.Setup();
            app.Run();
            // app.DisplayHelpInfo();
        }
    }
}
