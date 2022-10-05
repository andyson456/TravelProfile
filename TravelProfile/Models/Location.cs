using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LocationProfile.Models
{
    public class Location
    {
        public int Id { get; set; }
        public string Country { get; set; }
        public string State { get; set; }
        public string City { get; set; }
        public string PlacesOfInterest { get; set; }
        public string Image { get; set; }
    }
}
