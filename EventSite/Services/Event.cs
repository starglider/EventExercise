using System;

namespace EventSite.Services
{
    using System;
    using System.ComponentModel.DataAnnotations;


        public class Event
        {
            public int Id { get; set; } = 0;
            [Required]
            public string Name { get; set; } = string.Empty;
            [Required]
            [DataType(DataType.Date)]
            public DateTime Date { get; set; } = DateTime.Today;
            public string Description { get; set; } = string.Empty;
            [Required]
            public string Location { get; set; } = string.Empty;
            public List<string> Attendees { get; set; } = new List<string>();
        }
    
}