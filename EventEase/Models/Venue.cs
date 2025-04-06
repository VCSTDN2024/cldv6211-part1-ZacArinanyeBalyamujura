using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace EventEase.Models
{
    public class Venue
    {

        [Required]
        [Display(Name = "Venue ID")]

        public int VenueId { get; set; }
        [StringLength(100)]
        [Display(Name = "Venue Name")]

        public string VenueName { get; set; }

        [StringLength(100)]
        [Display(Name = "Venue Location")]
        public string VenueLocation { get; set; }

        [Required]
        public int Capacity { get; set; }

        [Required]
        [Display(Name = "Image URL")]

        public string ImageUrl { get; set; }

        public ICollection<Booking> Bookings { get; set; }

    }
}
