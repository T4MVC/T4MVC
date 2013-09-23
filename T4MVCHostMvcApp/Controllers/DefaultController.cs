using System.Web.Mvc;

namespace T4MVCHostMvcApp.Controllers
{
    public partial class DefaultController : Controller
    {
        public virtual ActionResult Index()
        {
            return View(MVC.Home.Views.Index);
        }

    }
}
