using System.ComponentModel.DataAnnotations;

namespace Dig.Data.Models
{
	public class User : BaseModel
	{
		public virtual string UserName { get; set; }
		public virtual string Password { get; set; }
		public virtual string Nickname { get; set; }
	}
}