using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lab16DependancyInjection.Models
{
    public class Destinations
    {
        public int ID { get; set; }
        public string Destination { get; set; }
        public string ExpectedWeather { get; set; }
        public int ExpectedTemp { get; set; }
        public string ShoeType { get; set; }
        public string ShirtType { get; set; }
        public string PantsType { get; set; }
        public bool Jacket { get; set; }

    }
}
