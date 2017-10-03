using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lab16George.Models
{
    public interface IDestinationRepository
    {
        IEnumerable<Destination> Destination { get; }
    }
}
