using EventBookingSystem.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace EventBookingSystem.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Booking> Booking { get; set; }
        public DbSet<Customer> Customer { get; set; }
        public DbSet<Event> Event { get; set; }
        public DbSet<Venue> Venue { get; set; }
    }
}
