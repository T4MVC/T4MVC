using System.Web.Mvc;

namespace T4MVCHostMvc5App.Areas.Home.Controllers
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
