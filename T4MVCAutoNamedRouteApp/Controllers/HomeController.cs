using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using T4MVCAutoNamedRouteApp.T4MVC;

namespace T4MVCAutoNamedRouteApp.Controllers
{
	[RoutePrefix( "" )]
	public partial class HomeController : Controller
	{
		public virtual ActionResult Index()
		{
			return View();
		}

		public virtual ActionResult About()
		{
			ViewBag.Message = "Your application description page.";

			return View();
		}

		public virtual ActionResult Contact()
		{
			ViewBag.Message = "Your contact page.";

			return View();
		}

		[AutoNamedRoute( "show-item-details/{id:int}" )]
		public virtual ActionResult Details( int id )
		{
			return View();
		}
	}
}