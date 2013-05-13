using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dig.Data.Models.Mock
{
	public class RefVarietyType
	{
		[ScaffoldColumn(false)]
		public int Id { get; set; }
		public string Name { get; set; }
	}
}
