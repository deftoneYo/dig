using System.Web.Mvc;

namespace Dig.MvcWeb.Areas.Mock
{
    public class MockAreaRegistration : AreaRegistration
    {
        public override string AreaName
        {
            get
            {
                return "Mock";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context)
        {
            context.MapRoute(
                "Mock_default",
                "Mock/{controller}/{action}/{id}",
                new { action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}
