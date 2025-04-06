using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EventEase.Models
{
    public class Event
    {
        [Required]
        [Display(Name = "Event ID")]
        public int EventId { get; set; }
        [Required]
        [Display(Name = "Event Name")]
        public string EventName { get; set; }
        [Required]
        [Display(Name = "Event Date")]
        public DateTime EventDate { get; set; }

        [Required]
        [Display(Name = "Event Description")]
        public string EventDescription { get; set; }

        public ICollection<Booking> Bookings { get; set; }

    }
}
