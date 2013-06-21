using System.ComponentModel.DataAnnotations;

namespace Dig.Data.Models
{
	public class Address : BaseModel
	{
		public virtual string Description { get; set; }
		public virtual string AddressLine1 { get; set; }
		public virtual string AddressLine2 { get; set; }
		public virtual string AddressLine3 { get; set; }
		public virtual string City { get; set; }
		public virtual string State { get; set; }
		public virtual string Zip { get; set; }
		public virtual string Geocode { get; set; }
	}
}
