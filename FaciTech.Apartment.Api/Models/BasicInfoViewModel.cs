using FaciTech.Apartment.Database.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace FaciTech.Apartment.Api.Models
{
    public class BasicInfoViewModel
    {
        public Guid Id { get; set; }
        [Required]
        public string Name { get; set; }
        public Guid SubAreaId { get; set; }
        public string BuilderName { get; set; }
        public string Address { get; set; }
        public string Landmark { get; set; }
        public string LocationLink { get; set; }
      
    }
}
