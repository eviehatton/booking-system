using EventBookingSystem.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Linq;

namespace EventBookingSystem.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new ApplicationDbContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<ApplicationDbContext>>()))
            {
                if (context.Booking.Any())
                {
                    return;
                }

                Customer fry = new Customer
                {
                    FirstName = "Philip",
                    LastName = "Fry",
                    Email = "philip.j.fry@planex.earth"
                };

                context.Customer.AddRange(
                    fry,
                    new Customer
                    {
                        FirstName = "Turanga",
                        LastName = "Leela",
                        Email = "leelaxo@gmail.com"
                    },
                    new Customer {
                        FirstName = "Amy",
                        LastName = "Wong",
                        Email = "amywong2984@mommail.com"
                    }
                );

                Venue menArena = new Venue
                {
                    Name = "MEN Arena",
                    Capacity = 21000,
                    Location = "Manchester"
                };

                context.Venue.AddRange(
                    menArena,
                    new Venue
                    {
                        Name = "The O2",
                        Capacity = 20000,
                        Location = "Greenwich, London"
                    }
                );
                Venue Academy = new Venue
                {
                    Name = "Academy 1",
                    Capacity = 21000,
                    Location = "Manchester"
                };

                context.Venue.AddRange(
                    menArena,
                    new Venue
                    {
                        Name = "Aacdemy 2",
                        Capacity = 950,
                        Location = "Oxford Rd, Manchester"
                    }
                   );

                Event littleMix = new Event
                {
                    Name = "Little Mix (Manchester)",
                    Description = "",
                    StartTime = new DateTime(2022, 5, 13, 18, 30, 0),
                    Price = 69.0m,
                    EventVenue = menArena
                };

                context.Event.Add(littleMix);

                Event HarryStyles = new Event
                {
                    Name = "Harry Styles (Manchester)",
                    Description = "Love On Tour",
                    StartTime = new DateTime(2022, 3, 13, 19, 00, 0),
                    Price = 150.0m,
                    EventVenue = menArena
                };

                context.Event.Add(HarryStyles);

                Event LouisTomlinson = new Event
                {
                    Name = "Louis Tomlinson (Manchester)",
                    Description = "",
                    StartTime = new DateTime(2021, 9, 19, 19, 00, 0),
                    Price = 64.0m,
                    EventVenue = menArena
                };

                context.Event.Add(LouisTomlinson);

                Booking fryAtLittleMixInManchester = new Booking
                {
                    Customer = fry,
                    Event = littleMix,
                    Price = 69.0m,
                    SeatBlock = 1,
                    SeatNumber = 1
                };
                context.Booking.Add(fryAtLittleMixInManchester);
                context.SaveChanges();
            }
        }
    }
}
