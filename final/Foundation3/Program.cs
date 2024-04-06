using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Foundation3 World!");

        var events = new List<Event>
        {
            new Lecture
            {
                Title = "Lecture on C#",
                Description = "An in-depth look at C# and .NET",
                Date = DateTime.Today.AddDays(7),
                Time = new TimeSpan(18, 0, 0),
                Address = new Address { Street = "123 Main St", City = "Anytown", State = "NY", Country = "USA" },
                Speaker = "John Doe",
                Capacity = 100
            },
            new Reception
            {
                Title = "Networking Reception",
                Description = "A chance to network with industry professionals",
                Date = DateTime.Today.AddDays(14),
                Time = new TimeSpan(19, 0, 0),
                Address = new Address { Street = "456 Elm St", City = "Othertown", State = "NY", Country = "USA" },
                RSVPEmail = "rsvp@example.com"
            },
            new OutdoorGathering
            {
                Title = "Company Picnic",
                Description = "A fun day out for the whole family",
                Date = DateTime.Today.AddDays(21),
                Time = new TimeSpan(12, 0, 0),
                Address = new Address { Street = "789 Pine St", City = "Sometown", State = "NY", Country = "USA" },
                WeatherForecast = "Sunny with a high of 75"
            }
        };

        foreach (var eventItem in events)
        {
            Console.WriteLine(eventItem.GetFullDetails());
            Console.WriteLine();
        }
    }
}