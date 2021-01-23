using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EventBookingSystem.Models
{
    public class Event
    {
        public int EventId { get; set; }

        [StringLength(60, MinimumLength = 5)]
        [Required]
        public string Name { get; set; }

        [StringLength(500, MinimumLength = 50)]
        public string Description { get; set; }
        
        [DataType(DataType.Date)]
        public DateTime StartTime { get; set; }

        [Range(1, 250)]
        [DataType(DataType.Currency)]
        [Column(TypeName = "decimal(18, 2)")] 
        public decimal Price { get; set; }

        public int VenueId { get; set; }

        public Venue Venue { get; set; }

        public virtual ICollection<Booking> Bookings { get; set; }
    }
}