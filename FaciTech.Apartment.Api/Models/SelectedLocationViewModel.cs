using System;
using System.Collections.Generic;

namespace FaciTech.Apartment.Api.Models
{
    public class SelectedLocationViewModel
    {
        public SelectedLocationViewModel()
        {
            
        }
        public List<LocationViewModel> Countries { get; set; }
        public List<LocationViewModel> Cities { get; set; }
        public List<LocationViewModel> Areas { get; set; }
        public List<LocationViewModel> SubAeras { get; set; }
        public Guid CountryId { get; set; }
        public Guid CityId { get; set; }
        public Guid AreaId { get; set; }
        public Guid SubAreaId { get; set; }
        
    }
}
