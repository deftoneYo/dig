using System.ComponentModel.DataAnnotations;

namespace Dig.Data.Models
{
    public class Location : BaseModel
    {
	    public virtual string Name { get; set; }
	    public virtual string NickName { get; set; }
		//public virtual int LocationTypeId { get; set; }
		public virtual int AddressId { get; set; }
    }
}
