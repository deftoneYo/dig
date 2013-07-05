using System;
using Dig.Data.Models;
using Dig.Data.Repositories;
using NUnit.Framework;

namespace Dig.Tests.DataAccess
{
	[TestFixture]
	public class PrimaryRepoTest
	{
		private Dig.Data.Repositories.LocationRepository _locationRepo = new LocationRepository();

		[SetUp]
		public void Setup()
		{
			//log4net.Config.XmlConfigurator.Configure();
			//*** NH Profiler - this sends data to the profiler.
			HibernatingRhinos.Profiler.Appender.NHibernate.NHibernateProfiler.Initialize();
		}

		[Test]
		public void CreateAndPopulateDatabase()
		{
			NhibernateHelper.CreateDatabaseSchema();
			TestData.CreateTestData();
		}


		#region "Locations"

			[Test]
			public void Location_Can_Add()
			{
				var location = new Location()
				{
					AddressId = 0,
					CreatedByUserId = 0,
					CreatedDate = new DateTime(2013, 1, 1),
					Id = 1,
					ModifiedByUserId = 0,
					ModifiedDate = new DateTime(2013, 1, 1),
					Name = "Test",
					NickName = "Testerasdf"
				};
				var repo = new Dig.Data.Repositories.LocationRepository();
				repo.Add(location);



			}

			[Test]
			public void Location_Can_Edit()
			{
				var location = new Location {Id=1, AddressId = 1, CreatedByUserId = 1, CreatedDate = new DateTime(2013,1,1), ModifiedByUserId = 2, ModifiedDate = new DateTime(2013,1,2), Name = "Flannagan's Dublinzzzzzzzz", NickName = "Flans"};

				var repo = new Dig.Data.Repositories.LocationRepository();
				repo.Update(location);
			}

			[Test]
			public void Location_Get_All()
			{
				var records = _locationRepo.GetAll();
				Console.WriteLine("count = " + records.Count.ToString());
				Assert.IsTrue(records.Count > 0);
			}
        
			[Test]
			public void Location_Get_By_Name()
			{
				var records = _locationRepo.SearchByName("ar");
				foreach (var location in records)
				{
					Console.WriteLine(location.Name);
				}
				Console.WriteLine("count = " + records.Count);
				Assert.IsTrue(records.Count > 0);
			}

		#endregion



		[Test]
		public void Can_add_new_address()
		{
			var address = new Address()
				{
					Id = 1,
					CreatedByUserId = 0,
					CreatedDate = new DateTime(2013, 1, 1),
					ModifiedByUserId = 0,
					ModifiedDate = new DateTime(2013, 1, 1),
					AddressLine1 = "address1",
					AddressLine2 = "address2",
					AddressLine3 = "address3", 
					City = "city", State = "ST", Zip = "44444",
					Description = "a new address",
					Geocode = "1.1234567890"
				};
			var repo = new Dig.Data.Repositories.AddressRespository();
			repo.Add(address);
		}


	}
}
