using System.Web.Mvc;

namespace Dig.MvcWeb.Areas.Mock.Controllers
{
    public class MockController : Controller
    {
        //
        // GET: /Mock/Mock/

        public ActionResult Index()
        {
            return View();
        }

        #region Generic Mocks
        public ActionResult AutoComplete()
        {
            return View();
        }
        #endregion

        public ActionResult EventGrid()
        {
            return View();
        }

		public ActionResult VarietyGrid()
		{

			return View();
		}
    }
}
