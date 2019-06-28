using FaciTech.Apartment.BL.Dtos;
using FaciTech.Apartment.Database;
using FaciTech.Apartment.Database.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FaciTech.Apartment.BL
{
    public class LocationService : FacitechBusinessService
    {
        public LocationService(FaciTechDbContext faciTechDbContext) : base(faciTechDbContext)
        {
            _faciTechDbContext = faciTechDbContext;
        }
        public async Task<List<Country>> GetCountriesAsync()
        {
            return await _faciTechDbContext.Country.ToListAsync();
        }
        public async Task<List<City>> GetCitiesByCountryIdAsync(int countryId)
        {
            return await _faciTechDbContext.City.Where(e => e.CountryId == countryId).ToListAsync();
        }
        public async Task<List<Area>> GetAreasByCityIdAsync(int cityId)
        {
            return await _faciTechDbContext.Area.Where(e => e.CityId == cityId).ToListAsync();
        }
        public async Task<List<SubArea>> GetSubAreasByAreaIdAsync(int areaId)
        {
            return await _faciTechDbContext.SubArea.Where(e => e.AreaId == areaId).ToListAsync();
        }
        public List<Country> GetCountries()
        {
            return GetCountriesAsync().Result();
        }
        public List<City> GetCitiesByCountryId(int countryId)
        {
            return GetCitiesByCountryIdAsync(countryId).Result();
        }
        public List<Area> GetAreasByCityId(int cityId)
        {
            return GetAreasByCityIdAsync(cityId).Result();
        }
        public List<SubArea> GetSubAreasByAreaId(int areaId)
        {
            return GetSubAreasByAreaIdAsync(areaId).Result();
        }
        public LocationDto GetChildLocations(int countryId, int cityId, int areaId)
        {
            var countriesTask = this.GetCountriesAsync();
            var citiesTask = this.GetCitiesByCountryIdAsync(countryId);
            var areasTask = this.GetAreasByCityIdAsync(cityId);
            var subareaTask = this.GetSubAreasByAreaIdAsync(areaId);

            Task.WaitAll(countriesTask, citiesTask, areasTask, subareaTask);

            LocationDto locationDto = new LocationDto();
            locationDto.Countries = countriesTask.Result;
            locationDto.Cities = citiesTask.Result;
            locationDto.Areas = areasTask.Result;
            locationDto.SubAreas = subareaTask.Result;

            return locationDto;
        }
    }
}
