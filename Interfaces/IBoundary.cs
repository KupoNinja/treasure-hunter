using System.Collections.Generic;
using TreasureHunter.Models;

namespace TreasureHunter.Interfaces
{
    public interface IBoundary
    {
        string Name { get; set; }
        string Description { get; set; }
        string AltDescription { get; set; }
        List<IItem> Items { get; set; }
        List<Event> Events { get; set; }
        Dictionary<string, IBoundary> NeighborBoundaries { get; set; }

        // string AltDescription { get; set; } //NOTE you might not use this but could be useful for extension ideas
        // bool IsLosable { get; set; } //NOTE you might not use this but could be useful for extension ideas

        void AddNeighborBoundary(IBoundary neighbor, bool autoAdd);
        void DisplayNeighborBoundaries();
        void DisplayLocationItems();
    }
}