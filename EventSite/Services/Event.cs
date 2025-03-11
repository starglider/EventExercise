using System;

namespace EventSite.Services
{
    public class Event
    {
        public int Id { get; set; } = 0;
        public string Name { get; set; } = string.Empty;
        public DateTime Date { get; set; } = DateTime.Today;
        public string Description { get; set; } = string.Empty;
        public string Location { get; set; } = string.Empty;
    }
}