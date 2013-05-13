using System;
using System.ComponentModel.DataAnnotations;
namespace Dig.Data.Models.Mock
{
	public class Variety
	{
		[ScaffoldColumn(false)]
		public int Id { get; set; }
		public int RefVarietyTypeId { get; set; }
		[Required]
		public string Name { get; set; }
		public string LongDescription { get; set; }
		[Required]
		public DateTime DateStart { get; set; }
		public DateTime DateEnd { get; set; }
		public DateTime? DateTimeStart { get; set; }
		public DateTime? DateTimeEnd { get; set; }
		public bool IsActive { get; set; }
	}
}
