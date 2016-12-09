using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace T4MVCHostMvc5App.Areas.Break.Controllers
{
    [RouteArea( "break", AreaPrefix = "post" )]
    public partial class RouteController : Controller
    {
        [AutoNamedRoute( "auto-named-action/{id:int}" )]
        public virtual ActionResult AutoNamedAction( int id )
        {
            return View();
        }
    }
}