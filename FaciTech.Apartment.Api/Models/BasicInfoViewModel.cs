using FaciTech.Apartment.Database.Models;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace FaciTech.Apartment.Api.Models
{
    public class BasicInfoViewModel
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        public int SubAreaId { get; set; }
        public string BuilderName { get; set; }
        public string Address { get; set; }
        public string Landmark { get; set; }
        public string LocationLink { get; set; }
      
    }
}
