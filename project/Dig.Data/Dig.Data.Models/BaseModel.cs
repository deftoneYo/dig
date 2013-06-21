using System;
using System.ComponentModel.DataAnnotations;

namespace Dig.Data.Models
{
	public class BaseModel
	{
		[ScaffoldColumn(false)]
		public virtual int Id { get; set; }
		public virtual int ModifiedByUserId { get; set; }
		public virtual DateTime ModifiedDate { get; set; }
		public virtual int CreatedByUserId { get; set; }
		public virtual DateTime CreatedDate { get; set; }
		public virtual Boolean IsActive { get; set; }
	}
}
