using FaciTech.Apartment.Api.Extenstion;
using FaciTech.Apartment.Api.Models;
using FaciTech.Apartment.BL;
using FaciTech.Apartment.Database;
using Microsoft.AspNet.OData;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Linq;

namespace FaciTech.Apartment.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]

    public class CountriesController : ControllerBase
    {
        FaciTechDbContext _faciTechDbContext;
        public CountriesController(FaciTechDbContext faciTechDbContext)
        {
            _faciTechDbContext = faciTechDbContext;
        }
        // GET api/countries
        [EnableQuery]
        [HttpGet]
        public ActionResult<IQueryable<LocationViewModel>> Get()
        {
            LocationService locationService = new LocationService(_faciTechDbContext);
            try
            {
                var response = _faciTechDbContext.Country.Select(e => new LocationViewModel()
                {
                    Id = e.Id.ToString(),
                    Name = e.Name
                })
                .AsQueryable();
                return Ok(response);
            }
            catch (Exception ex)
            {
                return new UnknownErrorResult(ex);
            }
        }
        // GET api/country/5
        [HttpGet("{id}")]
        public ActionResult<string> Get(int id)
        {
            return "value";
        }
        

        // POST api/country
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/country/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
