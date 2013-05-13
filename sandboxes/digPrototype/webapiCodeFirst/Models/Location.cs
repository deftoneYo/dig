using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace webapiCodeFirst.Models
{
	public class Location
	{
		[ScaffoldColumn(false)]
		public int Id { get; set; }
		[Required]
		public string Name { get; set; }
		public string Nickname { get; set; }
		public int AddressId { get; set; }
		public string Phone1 { get; set; }
		public string Phone2 { get; set; }
		public string Url { get; set; }
		public string Email1 { get; set; }
		public string Email2 { get; set; }
		public string Logo { get; set; }
		public string Manager { get; set; }
		public string Description { get; set; }
		public string Notes { get; set; }
		public string Geocode { get; set; }
		public int refLocationTypeId { get; set; }
		public bool IsActive { get; set; }
	}
}