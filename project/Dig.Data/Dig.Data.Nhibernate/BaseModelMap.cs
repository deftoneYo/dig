using Dig.Data.Models;
using NHibernate;
using NHibernate.Mapping.ByCode;
using NHibernate.Mapping.ByCode.Conformist;

namespace Dig.Data.Nhibernate
{
	public class BaseModelMap<T> : ClassMapping<T> where T : BaseModel
	{
		public BaseModelMap()
		{
			Id(x => x.Id, m => m.Generator(Generators.Native));
			Property(x => x.CreatedByUserId);
			Property(x => x.CreatedDate);
			Property(x => x.ModifiedByUserId);
			Property(x => x.ModifiedDate);
			Property(x => x.IsActive);
		}
	}

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

	public class UserMap : BaseModelMap<User>
	{
		public UserMap()
		{
			Property(x => x.UserName);
			Property(x => x.Password);
			Property(x => x.Nickname);
		}
	}
}
