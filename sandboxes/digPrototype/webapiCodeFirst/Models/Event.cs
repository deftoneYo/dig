using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using DataAnnotationsExtensions;


namespace webapiCodeFirst.Models

{
	public class Event
	{
		[ScaffoldColumn(false)]
		public int Id { get; set; }
		public int RefEventTypeId { get; set; }
		public int LocationsId { get; set; }
		[Required]
		public string Name { get; set; }
		[Required]
		public DateTime DateStart { get; set; }
		[Required]
		public DateTime DateEnd { get; set; }
		public string Host { get; set; }
		public string Manager { get; set; }
		public string Sponsors { get; set; }
		public string Description { get; set; }
		public bool IsActive { get; set; }

		public IEnumerable<Tournament> Tournaments { get; set; }
	}
}