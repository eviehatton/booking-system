using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace EventBookingSystem.Models
{
    public class Booking
    {
        public int Id { get; set; }

        [Range(1, 100)]
        public int SeatBlock { get; set; }

        [Range(1, 100)]
        public int SeatNumber { get; set; }

        [Range(1, 250)]
        [DataType(DataType.Currency)]
        [Column(TypeName = "decimal(18, 2)")]
        public decimal Price { get; set; }

        public int CustomerId { get; set; }

        public Customer Customer { get; set; }

        public int EventId { get; set; }

        public Event Event { get; set; }
    }
}
