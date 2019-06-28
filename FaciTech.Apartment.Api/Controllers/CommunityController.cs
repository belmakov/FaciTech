using AutoMapper;
using FaciTech.Apartment.Api.Models;
using FaciTech.Apartment.BL;
using FaciTech.Apartment.Database;
using FaciTech.Apartment.Database.Models;
using Microsoft.AspNet.OData;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;

namespace FaciTech.Apartment.Api.Controllers
{
    [Route("api/[controller]")]
    public class CommunityController : Controller
    {
        FaciTechDbContext _faciTechDbContext;
        private readonly IMapper _mapper;
        LocationService _locationService;
        public CommunityController(FaciTechDbContext faciTechDbContext, IMapper mapper)
        {
            _faciTechDbContext = faciTechDbContext;
            _locationService = new LocationService(_faciTechDbContext);
            _mapper = mapper;
        }
        // GET: api/<controller>
        [HttpGet]
        [EnableQuery]
        public ActionResult<IQueryable<CommunityViewModel>> Get()
        {
            return null;
        }

        // GET api/<controller>/5
        [HttpGet("{id}")]
        public JsonResult Get(int id)
        {
            var communityLocation = _faciTechDbContext.CommunityLocation.Where(e => e.Id == id).FirstOrDefault();
            var locationDto = _locationService.GetChildLocations(communityLocation.CountryId, communityLocation.CityId, communityLocation.AreaId);
            CommunityViewModel communityViewModel = new CommunityViewModel(communityLocation,locationDto);
            return Json(communityViewModel);
        }

        // POST api/<controller>
        [HttpPost]
        public void Post([FromBody]BasicInfoViewModel basicInfo)
        {

        }

        // PUT api/<controller>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]BasicInfoViewModel basicInfo)
        {
            var community = _faciTechDbContext.Community.Where(e => e.Id == id).FirstOrDefault();

            _mapper.Map(basicInfo, community);

            community.Name = basicInfo.Name;
            community.BuilderName = basicInfo.BuilderName;
            community.SubAreaId = basicInfo.SubAreaId;
            community.Landmark = basicInfo.Landmark;
            community.LocationLink = basicInfo.LocationLink;
            community.Address = basicInfo.Address;
            _faciTechDbContext.SaveChanges();
        }
        [HttpPut("{id}/association")]
        public void Put(int id, [FromBody]WelfareAssociation welfareAssociation)
        {
            var community = _faciTechDbContext.Community.Where(e => e.Id == id).FirstOrDefault();
            community.AssociationName = welfareAssociation.Name;
            community.AssociationNumber = welfareAssociation.Number;
            community.AssociationBankName = welfareAssociation.BankName;
            community.AssociationBankAccountNumber = welfareAssociation.BankAccountNumber;
            community.AssociationBankBranchAddress = welfareAssociation.BankBranchAddress;
            community.AssociationBankIFSC = welfareAssociation.Ifsc;
            _faciTechDbContext.SaveChanges();
        }

        // DELETE api/<controller>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
