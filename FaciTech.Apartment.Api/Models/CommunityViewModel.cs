using FaciTech.Apartment.BL.Dtos;
using FaciTech.Apartment.Database.Models;

namespace FaciTech.Apartment.Api.Models
{
    public class CommunityViewModel
    {
        public CommunityViewModel(CommunityLocation communityLocation, LocationDto locationDto)
        {
            this.Map(communityLocation,locationDto);
        }
        public BasicInfoViewModel BasicInfo { get; set; }
        public WelfareAssociation WelfareAssociation { get; set; }
        public SelectedLocationViewModel SelectedLocation { get; set; }
        public void Map(CommunityLocation communityLocation, LocationDto locationDto)
        {
            BasicInfo = new BasicInfoViewModel()
            {
                Name = communityLocation.Name,
                BuilderName = communityLocation.BuilderName,
                SubAreaId = communityLocation.SubAreaId,
                Address = communityLocation.Address,
                Id = communityLocation.Id,
                Landmark = communityLocation.Landmark,
                LocationLink = communityLocation.LocationLink,
            };
            WelfareAssociation = new WelfareAssociation()
            {
                Name = communityLocation.AssociationName,
                Number = communityLocation.AssociationNumber,
                BankAccountNumber = communityLocation.AssociationNumber,
                BankBranchAddress = communityLocation.AssociationBankBranchAddress,
                BankName = communityLocation.AssociationBankName,
                Ifsc = communityLocation.AssociationBankIFSC
            };
            SelectedLocation = MapLocation(communityLocation, locationDto);
        }
        public static SelectedLocationViewModel MapLocation(CommunityLocation communityLocation, LocationDto locationDto)
        {

            var selectedLocationViewModel = new SelectedLocationViewModel();
            selectedLocationViewModel.Countries = LocationViewModel.Map(locationDto.Countries);
            selectedLocationViewModel.Cities = LocationViewModel.Map(locationDto.Cities);
            selectedLocationViewModel.Areas = LocationViewModel.Map(locationDto.Areas);
            selectedLocationViewModel.SubAeras = LocationViewModel.Map(locationDto.SubAreas);
            selectedLocationViewModel.CountryId = communityLocation.CountryId.ToString();
            selectedLocationViewModel.CityId = communityLocation.CityId.ToString();
            selectedLocationViewModel.AreaId = communityLocation.AreaId.ToString();
            selectedLocationViewModel.SubAreaId = communityLocation.SubAreaId.ToString();
            return selectedLocationViewModel;
        }
    }
}
