using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace T4MVCHostMvcApp.Features.Pictures
{
    public partial class PicturesController : Controller
    {
        public virtual ActionResult Index()
        {
            return View();
        }

        public virtual ActionResult Detail()
        {
            return View();
        }
    }
}
