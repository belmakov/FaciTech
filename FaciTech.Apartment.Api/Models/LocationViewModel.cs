using System.Collections.Generic;

namespace FaciTech.Apartment.Api.Models
{
    public class LocationViewModel
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public static List<LocationViewModel> Map(IEnumerable<object> locations)
        {
            List<LocationViewModel> locationViewModels = new List<LocationViewModel>();
            foreach (var location in locations)
            {
                locationViewModels.Add(new LocationViewModel()
                {
                    Id = location.GetType().GetProperty("Id").GetValue(location).ToString(),
                    Name = location.GetType().GetProperty("Name").GetValue(location).ToString(),
                });
            }
            return locationViewModels;
        }
    }
    
}
