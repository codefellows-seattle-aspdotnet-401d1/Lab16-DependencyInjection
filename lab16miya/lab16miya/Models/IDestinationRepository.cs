using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace lab16miya.Models
{
    public interface IDestinationRepository
    {
        IEnumerable<Destination> Destination
        {
            get;
        }
    }
}
