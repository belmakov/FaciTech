using FaciTech.Apartment.BL.Dtos;
using FaciTech.Apartment.Database;
using FaciTech.Apartment.Database.Models;
using Microsoft.EntityFrameworkCore;
using System;
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
        public async Task<List<State>> GetStatesByCountryIdAsync(Guid countryId)
        {
            return await _faciTechDbContext.State.Where(e => e.CountryId == countryId).ToListAsync();
        }
        public async Task<List<City>> GetCitiesByStateIdAsync(Guid stateId)
        {
            return await _faciTechDbContext.City.Where(e => e.StateId == stateId).ToListAsync();
        }
        public async Task<List<Area>> GetAreasByCityIdAsync(Guid cityId)
        {
            return await _faciTechDbContext.Area.Where(e => e.CityId == cityId).ToListAsync();
        }
        public async Task<List<SubArea>> GetSubAreasByAreaIdAsync(Guid areaId)
        {
            return await _faciTechDbContext.SubArea.Where(e => e.AreaId == areaId).ToListAsync();
        }
        public List<Country> GetCountries()
        {
            return GetCountriesAsync().Result();
        }
        public List<State> GetStatesByCountryId(Guid countryId)
        {
            return GetStatesByCountryIdAsync(countryId).Result();
        }
        public List<City> GetCitiesByStateId(Guid stateId)
        {
            return GetCitiesByStateIdAsync(stateId).Result();
        }
        public List<Area> GetAreasByCityId(Guid cityId)
        {
            return GetAreasByCityIdAsync(cityId).Result();
        }
        public List<SubArea> GetSubAreasByAreaId(Guid areaId)
        {
            return GetSubAreasByAreaIdAsync(areaId).Result();
        }
        public LocationDto GetChildLocations(Guid countryId, Guid stateId, Guid cityId, Guid areaId)
        {
            var countriesTask = this.GetCountriesAsync();
            var statesTask = this.GetStatesByCountryIdAsync(countryId);
            var citiesTask = this.GetCitiesByStateIdAsync(stateId);
            var areasTask = this.GetAreasByCityIdAsync(cityId);
            var subareaTask = this.GetSubAreasByAreaIdAsync(areaId);

            Task.WaitAll(countriesTask, statesTask, citiesTask, areasTask, subareaTask);

            LocationDto locationDto = new LocationDto();
            locationDto.Countries = countriesTask.Result;
            locationDto.Cities = citiesTask.Result;
            locationDto.Areas = areasTask.Result;
            locationDto.SubAreas = subareaTask.Result;

            return locationDto;
        }
    }
}
