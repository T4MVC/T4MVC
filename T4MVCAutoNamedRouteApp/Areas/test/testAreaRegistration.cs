using System.Web.Mvc;

namespace T4MVCAutoNamedRouteApp.Areas.test
{
    public class testAreaRegistration : AreaRegistration 
    {
        public override string AreaName 
        {
            get 
            {
                return "test";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context) 
        {
            context.MapRoute(
                "test_default",
                "test/{controller}/{action}/{id}",
                new { action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}