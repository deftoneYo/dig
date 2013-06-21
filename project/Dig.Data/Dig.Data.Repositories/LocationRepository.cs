using System;
using System.Collections.Generic;
using System.Linq;
using Dig.Data.Models;
using Dig.Data.Nhibernate;
using NHibernate;
using NHibernate.Criterion;
using NHibernate.Linq;

namespace Dig.Data.Repositories
{
    public class LocationRepository
    {
	    private Int32 _userId = 0;


		#region "Get Records"
			
			public ICollection<Location> GetAll()
			{
				using (var session = NhibernateHelper.OpenSession())
				{
					var locations = from location in session.Query<Location>().Where(y => y.IsActive) select location;
					return locations.ToList();
				}
			}

		#endregion

		public void Add(Location model)
		{
			model.CreatedByUserId = _userId;
			model.CreatedDate = DateTime.Now;
			model.ModifiedByUserId = _userId;
			model.ModifiedDate = DateTime.Now;
			using (var session = NhibernateHelper.OpenSession())
				using (var transaction = session.BeginTransaction())
				{
					session.Save(model);
					transaction.Commit();
				}
		}

		public void Update(Location model)
		{
			model.ModifiedByUserId = _userId;
			model.ModifiedDate = DateTime.Now;
			using (var session = NhibernateHelper.OpenSession())
				using (var transaction = session.BeginTransaction())
				{
					session.Update(model);
					transaction.Commit();
				}
		}

		public void Delete(Location model)
		{
			using (var session = NhibernateHelper.OpenSession())
			using (var transaction = session.BeginTransaction())
			{
				session.Delete(model);
				transaction.Commit();
			}
		}
		
		public void Activate(Location model)
		{
			model.ModifiedByUserId = _userId;
			model.ModifiedDate = DateTime.Now;
			model.IsActive = true;
			using (var session = NhibernateHelper.OpenSession())
			using (var transaction = session.BeginTransaction())
			{
				session.Update(model);
				transaction.Commit();
			}
		}

		public void Inactivate(Location model)
		{
			model.ModifiedByUserId = _userId;
			model.ModifiedDate = DateTime.Now;
			model.IsActive = false;
			using (var session = NhibernateHelper.OpenSession())
			using (var transaction = session.BeginTransaction())
			{
				session.Update(model);
				transaction.Commit();
			}
		}
    }
}
