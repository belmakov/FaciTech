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
        public string CountryId { get; set; }
        public string CityId { get; set; }
        public string AreaId { get; set; }
        public string SubAreaId { get; set; }
        
    }
}
