using Dig.Data.Models;
using NHibernate.Mapping.ByCode;
using NHibernate.Mapping.ByCode.Conformist;

namespace Dig.Data.Maps
{
	public class BaseModelMap<T> : ClassMapping<T> where T : BaseModel
	{
		public BaseModelMap()
		{
			Id(x => x.Id, m => m.Generator(Generators.Native));
            Property(x => x.CreatedByUserId);
			Property(x => x.CreatedDate);
			Property(x => x.ModifiedByUserId);
			Property(x => x.ModifiedDate),;
			Property(x => x.IsActive);
		}
	}
}
