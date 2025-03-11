using System;
using System.Collections.Generic;
using System.Linq;

namespace EventSite.Services
{


    public class EventsService
    {
        private List<Event> _events = new List<Event>
        {
            new Event { Id = 1, Name = "Blazor Workshop", Date = new DateTime(2025, 4, 10), Location = "Hogwarts" },
            new Event { Id = 2, Name = "Blazor Conference", Date = new DateTime(2025, 5, 15), Location = "Gotham City" },
            new Event { Id = 3, Name = "Blazor Bootcamp", Date = new DateTime(2025, 6, 20), Location = "Metropolis" },
            new Event { Id = 4, Name = "Advanced Blazor", Date = new DateTime(2025, 7, 25), Location = "Narnia" },
            new Event { Id = 5, Name = "Blazor for Beginners", Date = new DateTime(2025, 8, 30), Location = "Wakanda" },
            new Event { Id = 6, Name = "Blazor and Azure", Date = new DateTime(2025, 9, 5), Location = "Middle-earth" },
            new Event { Id = 7, Name = "Blazor Components", Date = new DateTime(2025, 10, 10), Location = "Pandora" },
            new Event { Id = 8, Name = "Blazor and WebAssembly", Date = new DateTime(2025, 11, 15), Location = "Springfield" },
            new Event { Id = 9, Name = "Blazor Security", Date = new DateTime(2025, 12, 20), Location = "Emerald City" },
            new Event { Id = 10, Name = "Blazor Performance", Date = new DateTime(2026, 1, 25), Location = "Atlantis" }
        };

        public void AddEvent(Event Event)
        {
            _events.Add(Event);
        }

        public void SaveEvent(Event Event)
        {
            var eventToSave = _events.FirstOrDefault(e => e.Id == Event.Id);
            if (eventToSave == null)
            {
                _events.Add(Event);
            }
        }

        public void RemoveEvent(int eventId)
        {
            var eventToRemove = _events.FirstOrDefault(e => e.Id == eventId);
            if (eventToRemove != null)
            {
                _events.Remove(eventToRemove);
            }
        }

        public void EditEvent(Event updatedEvent)
        {
            var eventToEdit = _events.FirstOrDefault(e => e.Id == updatedEvent.Id);
            if (eventToEdit != null)
            {
                eventToEdit.Name = updatedEvent.Name;
                eventToEdit.Date = updatedEvent.Date;
                eventToEdit.Location = updatedEvent.Location;
            }
        }

        public List<Event> GetAllEvents()
        {
            return _events;
        }

        public async Task<Event?> GetEventByIdAsync(int eventId)
        {
            return await Task.Run(() => _events.FirstOrDefault(e => e.Id == eventId));
        }

        public async Task AttendEventAsync(int eventId, string attendee)
        {
            var eventToAttend = await Task.Run(() => _events.FirstOrDefault(e => e.Id == eventId));
            if (eventToAttend != null)
            {
                eventToAttend.Attendees.Add(attendee);
            }
        }
    }
}