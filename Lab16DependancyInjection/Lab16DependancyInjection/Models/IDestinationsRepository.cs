using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lab16DependancyInjection.Models
{
    public interface IDestinationsRepository
    {
        IEnumerable<Destinations> Destinations { get; }
    }
}
