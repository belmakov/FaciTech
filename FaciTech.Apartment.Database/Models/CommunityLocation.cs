namespace FaciTech.Apartment.Database.Models
{
    public class CommunityLocation
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string BuilderName { get; set; }
        public string Country { get; set; }
        public int CountryId { get; set; }
        public string City { get; set; }
        public int CityId { get; set; }
        public string Area { get; set; }
        public int AreaId { get; set; }
        public string SubArea { get; set; }
        public int SubAreaId { get; set; }
        public string Address { get; set; }
        public string Landmark { get; set; }
        public string LocationLink { get; set; }
        public string AssociationName { get; set; }
        public string AssociationNumber { get; set; }
        public string AssociationBankName { get; set; }
        public string AssociationBankAccountNumber { get; set; }
        public string AssociationBankBranchAddress { get; set; }
        public string AssociationBankIFSC { get; set; }
    }
}
