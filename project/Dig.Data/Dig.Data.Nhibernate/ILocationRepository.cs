using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dig.Data.Models;

namespace Dig.Data.Nhibernate
{
	public interface ILocationRepository
	{
		void Add(Location location);
		void Update(Location location);
		void Remove(Location location);
		Location GetById(int locationId);
		ICollection<Location> GetByName(string name);
	}
}
