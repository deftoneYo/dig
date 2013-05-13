using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using Dig.Data.Models;


namespace Dig.Web.Models
{
	/// <summary>
	/// Build Events Data. Drop and Create each time the model is altered
	/// </summary>
	public class DigDbContextInit : DropCreateDatabaseIfModelChanges<DigDbContext>
	{
		protected override void Seed(DigDbContext context)
		{
			var digEvents = new List<Event>()            
            {
                new Event() { Name = "Doubles Big Money", DateStart = new DateTime(2013,3,1),DateEnd = new DateTime(2013,3,1), Description = "descript 1" },
                new Event() { Name = "Fuds", DateStart = new DateTime(2013,3,2),DateEnd = new DateTime(2013,3,2), Description = "descript 2" },
                new Event() { Name = "Dig it for the House", DateStart = new DateTime(2013,3,3),DateEnd = new DateTime(2013,3,3), Description = "descript 3" }
            };

			digEvents.ForEach(p => context.Events.Add(p));
			context.SaveChanges();
		}
	}
}