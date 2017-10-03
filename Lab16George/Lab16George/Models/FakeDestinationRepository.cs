using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lab16George.Models
{
    public class FakeDestinationRepository : IDestinationRepository
    {
        public IEnumerable<Destination> Destination => new List<Destination>
        {
            new Destination { }
        };
    }
}
