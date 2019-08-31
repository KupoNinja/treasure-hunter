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
            foreach (var kvp in NeighborBoundaries)
            {
                Console.WriteLine(kvp.Key);
            }
        }

        public void DisplayLocationItems()
        {
            foreach (var item in Items)
            {
                Console.WriteLine(item.Name);
            }
        }

        public Boundary(string name, string description)
        {
            Name = name;
            Description = description;
            AltDescription = "";
            Items = new List<IItem>();
            NeighborBoundaries = new Dictionary<string, IBoundary>();
        }
    }
}