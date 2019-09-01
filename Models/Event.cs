namespace TreasureHunter.Models
{
    public class Event
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public bool IsTriggered { get; set; }

        public Event(string name, string description)
        {
            Name = name;
            Description = description;
            IsTriggered = false;
        }
    }
}