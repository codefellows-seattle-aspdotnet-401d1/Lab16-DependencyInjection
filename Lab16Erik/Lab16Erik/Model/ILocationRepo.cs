using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lab16Erik.Model
{
    public interface ILocationRepo
    {
        IEnumerable<Location> Location { get; }
    }
}
