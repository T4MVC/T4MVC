using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using T4MVCHostMvcApp.Misc;

namespace T4MVCHostMvcApp.Controllers {
    [HandleError]
    public partial class ControllerWithoutSuffix : Controller {
        public virtual ActionResult Index() {
            return View();
        }
    }
}
