using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dig.Data.DomainClasses
{
    public class Location
    {
	    public int LocationId { get; set; }
	    public string Name { get; set; }
	    public string NickName { get; set; }
	    public int AddressId { get; set; }
    }
}
