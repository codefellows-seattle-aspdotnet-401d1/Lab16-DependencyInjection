using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lab16TravelPackers.Models
{
    public class FakeDestinationRepository : IDestinationRepository
    {
        public IEnumerable<Destination> Destination => new List<Destination>
        {
            new Destination { Location = "Maui Hawaii", SwimWear = "Swim Wear Essential", Shoes = "Sandals are ideal", SunBlock = "Sun Protection Highly Recomended", Weather = "Warm Humid", Budget = 800m},
            new Destination { Location = "Sitka Alaska", Weather = "Cold Rainy", Shoes = "Boots", RainGear = "Rain Gear ideal", Budget = 1300m}
            
        };
    }
}
