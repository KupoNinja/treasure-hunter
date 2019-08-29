using System;
using System.Collections.Generic;
using TreasureHunter.Interfaces;

namespace TreasureHunter.Models
{
    public class Player : IPlayer
    {
        public string Name { get; set; }
        public List<IItem> Inventory { get; set; }

        public void GetPlayerName()
        {
            Console.WriteLine("What is your name?");
            string name = Console.ReadLine();
            Name = name;
        }

        public Player()
        {
            Inventory = new List<IItem>();
        }
    }
}