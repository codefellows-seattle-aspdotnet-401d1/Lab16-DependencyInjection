using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lab16TravelPackers.Models
{
    public interface IDestinationRepository
    {
        IEnumerable<Destination> Destination { get; }
    }
}
