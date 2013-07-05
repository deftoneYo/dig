using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dig.Data.Models;
using Dig.Data.Nhibernate;
using NHibernate;

namespace NhibernateUnitTest
{
	public class TestData
	{
		private readonly static Location[] Locations = new[]
		{
			new Location {AddressId = 1, CreatedByUserId = 1, CreatedDate = new DateTime(2013,1,1), ModifiedByUserId = 2, ModifiedDate = new DateTime(2013,1,2), Name = "Flannagan's Dublin", NickName = "Flans", IsActive = true},
			new Location {AddressId = 2, CreatedByUserId = 1, CreatedDate = new DateTime(2013,1,1), ModifiedByUserId = 2, ModifiedDate = new DateTime(2013,1,2), Name = "Goat Dublin", NickName = "Goat", IsActive = true},
			new Location {AddressId = 3, CreatedByUserId = 1, CreatedDate = new DateTime(2013,1,1), ModifiedByUserId = 2, ModifiedDate = new DateTime(2013,1,2), Name = "Bogey Inn", NickName = "Bogey", IsActive = true},
			new Location {AddressId = 4, CreatedByUserId = 1, CreatedDate = new DateTime(2013,1,1), ModifiedByUserId = 2, ModifiedDate = new DateTime(2013,1,2), Name = "The Volleypark", NickName = "Volleypark", IsActive = true},
			new Location {AddressId = 5, CreatedByUserId = 1, CreatedDate = new DateTime(2013,1,1), ModifiedByUserId = 2, ModifiedDate = new DateTime(2013,1,2), Name = "Fred Beekman Park", NickName = "Beekman", IsActive = true},
			new Location {AddressId = 6, CreatedByUserId = 1, CreatedDate = new DateTime(2013,1,1), ModifiedByUserId = 2, ModifiedDate = new DateTime(2013,1,2), Name = "Woodlands Backyard", NickName = "Woodlands", IsActive = true},
			new Location {AddressId = 7, CreatedByUserId = 1, CreatedDate = new DateTime(2013,1,1), ModifiedByUserId = 2, ModifiedDate = new DateTime(2013,1,2), Name = "hidden record", NickName = "hidden", IsActive = false}

		};

		private readonly static Address[] Addresses = new[]
		{
			new Address {Description = "Flans", AddressLine1 = "6835 Caine Rd", AddressLine2 = "", AddressLine3 = "", City = "Columbus", State = "OH", Zip = "43235", Geocode = "", CreatedByUserId = 1, CreatedDate = new DateTime(2013,1,1), ModifiedByUserId = 2, ModifiedDate = new DateTime(2013,1,2), IsActive = true},
			new Address {Description = "Goat", AddressLine1 = "5730 Silver Falls St", AddressLine2 = "", AddressLine3 = "", City = "Dublin", State = "OH", Zip = "43016", Geocode = "", CreatedByUserId = 1, CreatedDate = new DateTime(2013,1,1), ModifiedByUserId = 2, ModifiedDate = new DateTime(2013,1,2), IsActive = true},
			new Address {Description = "Bogey", AddressLine1 = "6013 Glick Rd", AddressLine2 = "", AddressLine3 = "", City = "Dublin", State = "OH", Zip = "43017", Geocode = "", CreatedByUserId = 1, CreatedDate = new DateTime(2013,1,1), ModifiedByUserId = 2, ModifiedDate = new DateTime(2013,1,2), IsActive = true},
			new Address {Description = "Volleypark", AddressLine1 = "5501 Sandalwood Boulevard", AddressLine2 = "", AddressLine3 = "", City = "Columbus", State = "OH", Zip = "43229", Geocode = "", CreatedByUserId = 1, CreatedDate = new DateTime(2013,1,1), ModifiedByUserId = 2, ModifiedDate = new DateTime(2013,1,2), IsActive = true},
			new Address {Description = "Beekman", AddressLine1 = "2200 Carmack Road", AddressLine2 = "", AddressLine3 = "", City = "Columbus", State = "OH", Zip = "43210", Geocode = "", CreatedByUserId = 1, CreatedDate = new DateTime(2013,1,1), ModifiedByUserId = 2, ModifiedDate = new DateTime(2013,1,2), IsActive = true},
			new Address {Description = "Woodlands", AddressLine1 = "668 Grandview Avenue", AddressLine2 = "", AddressLine3 = "", City = "Columbus", State = "OH", Zip = "43215", Geocode = "", CreatedByUserId = 1, CreatedDate = new DateTime(2013,1,1), ModifiedByUserId = 2, ModifiedDate = new DateTime(2013,1,2), IsActive = true}
		};

		private readonly static User[] Users = new[]
		{
			new User{CreatedByUserId = 1, CreatedDate = new DateTime(2013,6,19), ModifiedByUserId = 1, ModifiedDate = new DateTime(2013,6,19), Nickname = "SystemAccount", UserName = "System", IsActive = true}
		};


		public static void CreateTestData()
		{
			using (var session = NhibernateHelper.OpenSession())
			using (var transaction = session.BeginTransaction())
			{
				foreach (var user in Users)
					session.Save(user);
				foreach (var product in Locations)
					session.Save(product);
				foreach (var address in Addresses)
					session.Save(address);
				transaction.Commit();
			}
		}
	}

}
