using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PackerPlanner.Models
{
    public class TestDestinationRepository : IRepository
    {
        public IEnumerable<Destination> Destination => new List<Destination>
        {
            new Models.Destination{LocationName = "Hawaii", Country = "USA", RequiredItems = {"Shorts", "Sandals", "Beach Towels", "Sunscreen"}},
            new Models.Destination{LocationName = "Dublin", Country = "Ireland", RequiredItems = {"Raincoat", "ID", "Castle Guidebook"}},
            new Models.Destination{LocationName = "Tokyo", Country = "Japan", RequiredItems = {"Clean White Socks", "Umbrella", "Adventurous Appetite"}}
        };
    }
}
