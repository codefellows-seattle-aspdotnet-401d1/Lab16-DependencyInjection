using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace lab16miya.Models
{
    public class DummyDestinationRepository : IDestinationRepository
    {
        public IEnumerable<Destination> Destination => new List<Destination>
        {
            //new Destination {Name = "Mario", Price = 100, SKU = "MAR135"},
            new Destination {City = "Honolulu", Country = "USA", Population = 375000, Attractions = "hiking, volcanoes, snorkeling"},
            new Destination {City = "Khasi Hills", Country = "India", Population = 385000, Attractions = "lots of rain"},
            new Destination {City = "Arenal Volcano", Country = "Costa Rica", Population = 8000, Attractions = "active volcanoes, ziplining"},
            new Destination {City = "Granite Falls", Country = "USA", Population = 3378, Attractions = "Big Four Ice Caves"},
            new Destination {City = "Saint-Bon-Tarentaise", Country = "France", Population = 1910, Attractions = "best ski resort called Courchevel"},
            new Destination {City = "Baia do Sancho", Country = "Brazil", Population = 5000, Attractions = "white sands, warm water"}

        };
    }
}
