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
    public class AreasController : ControllerBase
    {
        FaciTechDbContext _faciTechDbContext;
        public AreasController(FaciTechDbContext faciTechDbContext)
        {
            _faciTechDbContext = faciTechDbContext;
        }
        [EnableQuery]
        [HttpGet("/api/cities/{cityId:int}/[controller]")]
        public ActionResult<IQueryable<LocationViewModel>> GetAll(Guid cityId)
        {
            LocationService locationService = new LocationService(_faciTechDbContext);
            try
            {
                var response = _faciTechDbContext.Area.Where(e => e.CityId == cityId)
                    .Select(e => new LocationViewModel()
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

        // GET: api/Cities/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Cities
        [HttpPost("/api/cities/{cityId:int}/[controller]")]
        public void Post([FromBody] LocationViewModel city)
        {
        }

        // PUT: api/Cities/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
