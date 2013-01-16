using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Mvc.Ajax;

namespace T4MVCHostMvcApp.SomePortableArea.Controllers
{
    public partial class HomeController : Controller
    {
        //
        // GET: /Home/

        [ActionName("The Index")]
        public virtual ActionResult Index()
        {
            return View();
        }

    }
}
