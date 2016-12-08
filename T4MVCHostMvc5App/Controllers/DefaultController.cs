using System.Web.Mvc;

namespace T4MVCHostMvc5App.Controllers
{
    public partial class DefaultController : Controller
    {
        public virtual ActionResult Index()
        {
            return View(MVC.Home.Views.Index);
        }

    }
}
