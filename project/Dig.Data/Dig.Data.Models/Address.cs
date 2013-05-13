using System.ComponentModel.DataAnnotations;

namespace Dig.Data.Models
{
	class Address
	{
		[ScaffoldColumn(false)]
		public int AddressId { set; get; }
		public string Description { get; set; }
		public string AddressLine1 { get; set; }
		public string AddressLine2 { get; set; }
		public string AddressLine3 { get; set; }
		public string City { get; set; }
		public string State { get; set; }
		public string Zip { get; set; }
		public string Geocode { get; set; }
	}
}
