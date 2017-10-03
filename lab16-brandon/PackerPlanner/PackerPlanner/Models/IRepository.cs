using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PackerPlanner.Models
{
    public interface IRepository
    {
        IEnumerable<Destination> Destination { get; }
    }
}
