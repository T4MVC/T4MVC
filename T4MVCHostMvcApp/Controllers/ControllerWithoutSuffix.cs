using System.Web.Mvc;

namespace T4MVCHostMvcApp.Controllers {
    [HandleError]
    public partial class ControllerWithoutSuffix : Controller {
        public virtual ActionResult Index() {
            return View();
        }
    }
}
