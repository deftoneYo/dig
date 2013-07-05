using Dig.Data.Models;

namespace Dig.Data.Maps
{
    public class AddressMap : BaseModelMap<Address>
    {
        public AddressMap()
        {
            Property(x => x.Description);
            Property(x => x.AddressLine1);
            Property(x => x.AddressLine2);
            Property(x => x.AddressLine3);
            Property(x => x.City);
            Property(x => x.State);
            Property(x => x.Zip);
            Property(x => x.Geocode);
        }
    }
}
