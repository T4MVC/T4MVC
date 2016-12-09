using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace T4MVCHostMvc5App.Areas.Break
{
    public class BreakAreaRegistration : AreaRegistration
    {
        public override string AreaName
        {
            get
            {
                return "break";
            }
        }

        public override void RegisterArea( AreaRegistrationContext context )
        {
            context.MapRoute(
                "Break_default",
                "break/{controller}/{action}/{id}",
                new { action = "Index", id = UrlParameter.Optional },
                namespaces: new string[] { typeof( T4MVCHostMvc5App.Areas.Break.Controllers.PostController ).Namespace }
            );
        }
    }
}