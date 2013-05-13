using System;
using System.Collections.Generic;
using System.Data.Entity;
using Dig.Data.Models;
using Dig.Data.Models.Mock;


namespace Dig.MvcWeb.Models
{
	/// <summary>
	/// Build Events Data. Drop and Create each time the model is altered
	/// </summary>
	public class DigDbContextInit : DropCreateDatabaseAlways<DigDbContext>
	{
		protected override void Seed(DigDbContext context)
		{
			var digEvents = new List<Event>()            
            {
                new Event() { Name = "Doubles Big Money", DateStart = new DateTime(2013,3,1),DateEnd = new DateTime(2013,3,1), Description = "descript 1", IsActive = true },
                new Event() { Name = "Fuds", DateStart = new DateTime(2013,3,2),DateEnd = new DateTime(2013,3,2), Description = "descript 2", IsActive = false },
                new Event() { Name = "Dig it for the House", DateStart = new DateTime(2013,3,3),DateEnd = new DateTime(2013,3,3), Description = "descript 3", IsActive = true},
                new Event() { Name = "Dig it for the House2", DateStart = new DateTime(2013,4,3),DateEnd = new DateTime(2013,4,3), Description = "descript 3", IsActive = true},
                new Event() { Name = "Dig it for the House3", DateStart = new DateTime(2013,5,3),DateEnd = new DateTime(2013,5,3), Description = "descript 3", IsActive = false},
                new Event() { Name = "Dig it for the House4", DateStart = new DateTime(2013,3,3),DateEnd = new DateTime(2013,3,3), Description = "descript 3", IsActive = true},
            };

			var varieties = new List<Variety>()
			{
				new Variety() {Name = "FirstOne", LongDescription = "asdfl jasdf ajdsf kljfalkdfadfklajflajfd lkfj lsdf dsf jsdkfjdsf kjf kjdf kjfsdf kfjj df jk", DateStart = new DateTime(2013,3,2), DateEnd = new DateTime(2013,3,2), IsActive = true, RefVarietyTypeId = 1},
				new Variety() {Name = "SecondOne", LongDescription = "asdfl jasdfdsf kjf kjdf kjfsdf kfjj df jk", DateStart = new DateTime(2013,4,2), DateEnd = new DateTime(2013,4,2), IsActive = false, RefVarietyTypeId = 2},
				new Variety() {Name = "ThirdOne", LongDescription = "asdfl jasdf ajdsf kljfalkdfadfklajffjdsf kjf kjdf kjfsdf kfjj df jk", DateStart = new DateTime(2013,5,2), DateEnd = new DateTime(2013,5,2), IsActive = true, RefVarietyTypeId = 1},
				new Variety() {Name = "Fourth One", LongDescription = "asdfl jasdf ajdsf kljfalkdfadf kjdf kjfsdf kfjj df jk", DateStart = new DateTime(2013,5,2), DateEnd = new DateTime(2013,5,2), IsActive = true, RefVarietyTypeId = 1},
			};


			var refVarietyTypes = new List<RefVarietyType>()
			{
				new RefVarietyType() {Name="First Type"} ,
				new RefVarietyType() {Name="Second Type"} ,
				new RefVarietyType() {Name="Third Type"} ,
				new RefVarietyType() {Name="Fourth Type"} ,
				new RefVarietyType() {Name="Fifth Type"}
			};

			varieties.ForEach(p => context.Varieties.Add(p));
			refVarietyTypes.ForEach(p => context.RefVarieties.Add(p));
			digEvents.ForEach(p => context.Events.Add(p));
			context.SaveChanges();
		}
	}
}