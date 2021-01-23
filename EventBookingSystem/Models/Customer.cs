using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace EventBookingSystem.Models
{
    public class Customer
    {
        public int CustomerId { get; set; }

        [StringLength(25, MinimumLength = 3)]
        [Required]
        public String FirstName { get; set; }

        [StringLength(25, MinimumLength = 2)]
        [Required]
        public String LastName { get; set; }

        [RegularExpression(@"^\w+[\w-\.]*\@\w+((-\w+)|(\w*))\.[a-z]{2,3}$")]
        [StringLength(70)]
        [Required]
        public String Email { get; set; }

        public virtual ICollection<Booking> Bookings { get; set; }
    }
}
