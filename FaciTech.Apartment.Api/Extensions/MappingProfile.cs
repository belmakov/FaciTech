using AutoMapper;
using FaciTech.Apartment.Api.Models;
using FaciTech.Apartment.Database.Models;

namespace FaciTech.Apartment.Api.Extensions
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<CommunityViewModel, Community>();
            CreateMap<BasicInfoViewModel, Community>();
            CreateMap<WelfareAssociation, Community>();
        }
    }
}
