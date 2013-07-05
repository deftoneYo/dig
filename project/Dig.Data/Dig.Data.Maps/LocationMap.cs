using Dig.Data.Models;

namespace Dig.Data.Maps
{
    public class LocationMap : BaseModelMap<Location>
    {
        public LocationMap()
        {
            Property(x => x.Name);
            Property(x => x.NickName);
            //Property(x => x.LocationTypeId);
            Property(x => x.AddressId);

            //OneToOne(x => x.AddressId, x => {x});
        }
    }
}
