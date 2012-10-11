using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dig.Data.DomainClasses
{
	class Address
	{
		[Key]
		public int AddressId { set; get; }
		public string Description { get; set; }
		public string AddressLine1 { get; set; }
		public string AddressLine2 { get; set; }
		public string AddressLine3 { get; set; }
		public string City { get; set; }
	}
}
