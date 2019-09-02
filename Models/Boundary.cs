using System;
using System.Collections.Generic;
using System.Linq;
using TreasureHunter.Interfaces;

namespace TreasureHunter.Models
{
    public class Boundary : IBoundary
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public string AltDescription { get; set; }
        public List<IItem> Items { get; set; }
        // NOTE Not a big fan of using the List but can handle multiple events in the future.
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
            // NOTE This breaks when a room has no events but has items. Fixed with first if statement. Redundant if a room has an event.
            // NOTE Now this doesn't display items if the room doesn't have an event.
            Console.WriteLine("You can 'take' these items:");
            foreach (var item in Items)
            {
                Console.WriteLine(item.Name);
            }
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