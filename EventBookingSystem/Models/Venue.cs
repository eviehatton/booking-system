using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace EventBookingSystem.Models
{
    public class Venue
    {
        public int VenueId { set; get; }

        [Required]
        [StringLength(25)]
        public String Name { set; get; }

        [Required]
        [StringLength(25)]
        public String Location { set; get; }

        [Range(1, 10000)]
        public int Capacity { set; get; }

        public virtual ICollection<Event> Events { get; set; }
    }
}
