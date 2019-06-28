using FaciTech.Apartment.Database.Models;
using System.Collections.Generic;

namespace FaciTech.Apartment.BL.Dtos
{
    public class LocationDto
    {
        public List<Country> Countries { get; set; }
        public List<City> Cities { get; set; }
        public List<Area> Areas { get; set; }
        public List<SubArea> SubAreas { get; set; }
    }
}
