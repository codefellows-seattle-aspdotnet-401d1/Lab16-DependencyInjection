using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lab16Cameron.Models
{
    public class FakeDestinationRepository : IDestinationRepository
    {
        public IEnumerable<Destinations> GetDestination() => new List<Destinations>
        {
            new Destinations {Attraction = "Safari", Location = "South Africa", Nights = 7 },

            new Destinations {Attraction = "Swim with Stingrays", Location = "Cayman Islands", Nights = 5 },

            new Destinations {Attraction = "Hand Gliding", Location = "Rio De Janeiro, Brazil", Nights = 4 }
        };
        
    }
}
