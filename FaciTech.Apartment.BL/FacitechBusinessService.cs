using FaciTech.Apartment.Database;

namespace FaciTech.Apartment.BL
{
    public class FacitechBusinessService
    {
        protected FaciTechDbContext _faciTechDbContext;
        public FacitechBusinessService(FaciTechDbContext faciTechDbContext)
        {
            this._faciTechDbContext = faciTechDbContext;
        }
    }
}
