using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace webapiCodeFirst.Controllers
{
	public class HomeController : Controller
	{
		public ActionResult Index()
		{
			return View();
		}

		public ActionResult Events()
		{
			var apiUri = Url.HttpRouteUrl("DefaultApi", new { controller = "Events", });
			ViewBag.ApiUrl = new Uri(Request.Url, apiUri).AbsoluteUri.ToString();

			return View();
		}
	}
}
