using System;

namespace TreasureHunter
{
    class Program
    {
        static void Main(string[] args)
        {
            App app = new App();
            app.Setup();
            app.Run();
        }
    }
}
