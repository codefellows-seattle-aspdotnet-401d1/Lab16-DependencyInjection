using Microsoft.AspNetCore.Mvc;

namespace Lab16George.Models
{
    public class Destination
    {
        public int ID { get; set; }
        public string City { get; set; }
        public string Country { get; set; }
        public string Language { get; set; }
        public string Climate { get; set; }
    }
}
