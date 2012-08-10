using System.Web.Mvc;

namespace Dig.Web.Areas.BracketGen
{
    public class BracketGenAreaRegistration : AreaRegistration
    {
        public override string AreaName
        {
            get
            {
                return "BracketGen";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context)
        {
            context.MapRoute(
                "BracketGen_default",
                "BracketGen/{controller}/{action}/{id}",
                new { action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}
