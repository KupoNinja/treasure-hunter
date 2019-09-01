using System;
using System.Collections.Generic;
using TreasureHunter.Interfaces;

namespace TreasureHunter.Models
{
    public class Boundary : IBoundary
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public string AltDescription { get; set; }
        public List<IItem> Items { get; set; }
        public List<Event> Events { get; set; }
        public Dictionary<string, IBoundary> NeighborBoundaries { get; set; }

        public void AddNeighborBoundary(IBoundary neighbor, bool autoAdd = true)
        {
            NeighborBoundaries.Add(neighbor.Name, neighbor);
            if (autoAdd)
            {
                neighbor.AddNeighborBoundary(this, false);
            }
        }

        public void DisplayNeighborBoundaries()
        {
            Console.WriteLine("You can 'go' to these locations:");
            foreach (var kvp in NeighborBoundaries)
            {
                Console.WriteLine(kvp.Key);
            }
        }

        public void DisplayLocationItems()
        {
            // NOTE Take out this if statement if doing events as boundaries
            // NOTE Breaks here if attempting to 'look' in a room with no events.
            // if (Events[0].IsTriggered)
            // {
            Console.WriteLine("You can 'take' these items:");
            foreach (var item in Items)
            {
                Console.WriteLine(item.Name);
            }
            // }
            return;
        }

        public void DisplayLocationEvents()
        {
            Console.WriteLine("You can 'check' these events");
            foreach (var ev in Events)
            {
                Console.WriteLine(ev.Name);
            }
        }

        public Boundary(string name, string description)
        {
            Name = name;
            Description = description;
            AltDescription = "";
            Items = new List<IItem>();
            Events = new List<Event>();
            NeighborBoundaries = new Dictionary<string, IBoundary>();
        }
    }
}