using System.Collections.Generic;

namespace Lab16George.Models
{
    public interface IDestinationRepository
    {
        IEnumerable<Destination> Destinations { get; }
    }
}
