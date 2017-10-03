using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lab16DependancyInjection.Models
{
    public class FauxDestinationsRepository : IDestinationsRepository
    {
        public IEnumerable<Destinations> Destinations => new List<Destinations>
        {
            new Destinations {Destination = "Hawaii", ExpectedWeather = "Sunny", ExpectedTemp = 85, PantsType = "board shorts", ShirtType = "Hawaiian Shirt", ShoeType = "Sandals", Jacket = false },
            new Destinations {Destination = "Switzerland", ExpectedWeather = "Snowy", ExpectedTemp = 35, PantsType = "Snow Pants", ShirtType = "Thermal", ShoeType = "Snow Boots", Jacket = true },
            new Destinations {Destination = "Anchorage", ExpectedWeather = "Cold", ExpectedTemp = 25, PantsType = "Thermal", ShirtType = "Thermal", ShoeType = "Cold Weather Boots", Jacket = true },
            new Destinations {Destination = "Cairo", ExpectedWeather = "Sunny", ExpectedTemp = 110, PantsType = "Shorts", ShirtType = "Tank Top", ShoeType  = "Flip Flop", Jacket = false }
        };
    }
}
