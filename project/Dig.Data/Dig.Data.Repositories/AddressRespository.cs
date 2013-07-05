using System;
using Dig.Data.Models;

namespace Dig.Data.Repositories
{
	public class AddressRespository
	{
		public void Add(Address model)
		{
			using (var session = NhibernateHelper.OpenSession())
			using (var transaction = session.BeginTransaction())
			{
				session.Save(model);
				transaction.Commit();
			}
		}
	}
}
