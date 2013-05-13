using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Dig.Data.Models.Mock;
using Dig.MvcWeb.Models;

namespace Dig.MvcWeb.Controllers
{
    public class MockRefVarietiesController : ApiController
	{
		private readonly DigDbContext _db = new DigDbContext();


		// GET api/GetRefVarieties
		public IEnumerable<RefVarietyType> GetRefVarieties()
		{
			return _db.RefVarieties.AsEnumerable();
		}

    }
}
