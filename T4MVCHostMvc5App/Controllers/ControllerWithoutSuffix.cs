using System.Web.Mvc;

namespace T4MVCHostMvc5App.Controllers
{
    [HandleError]
    public partial class ControllerWithoutSuffix : Controller
    {
        public virtual ActionResult Index()
        {
            return View();
        }
    }
}
