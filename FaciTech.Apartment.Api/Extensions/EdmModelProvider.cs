using FaciTech.Apartment.Database.Models;
using Microsoft.AspNet.OData.Builder;
using Microsoft.OData.Edm;

namespace FaciTech.Apartment.Api
{
    public static class EdmModelProvider
    {
        public static IEdmModel AddEntitySet(this ODataConventionModelBuilder builder)
        {
            builder.AddEntitySet<Country>();
          

            return builder.GetEdmModel();
        }
        private static void  AddEntitySet<T>(this ODataConventionModelBuilder builder) where T : class {
            builder.EntitySet<T>((typeof(T).Name));
        }
    }
}
