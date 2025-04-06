using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.Extensions.Logging;

namespace EventEase.Models
{
    public class Booking
    {


        [Required]
        [Display(Name = "Booking ID")]
        public int BookingId { get; set; }
        [DataType(DataType.Date)]
        [Display(Name = "Booking Date")]
        public DateTime BookingDate { get; set; }

        // Foreign Keys

        [ForeignKey("EventId")]
        [Display(Name = "Event ID")]

        public int EventId { get; set; }

        [ForeignKey("VenueId")]
        [Display(Name = "Venue ID")]
        public int VenueId { get; set; }

        // Navigation Properties
        public Venue Venue { get; set; }
        public Event Event { get; set; }




    }
}
