using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lab16Cameron.Models
{
    public interface IDestinationRepository
    {
        IEnumerable<Destinations> GetDestination();
    }
}
