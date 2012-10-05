using System.Web.Mvc;

namespace T4MVCHostMvcApp.Areas.Home.Controllers {
    public partial class HomeController : Controller {
        //
        // GET: /Home/

        [ActionName("The Index")]
        public virtual ActionResult Index() {
            return View();
        }

    }
}
