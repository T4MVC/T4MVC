using System.Web.Mvc;

namespace T4MVCHostMvcApp.Areas.FeatureFolderArea.FeatureFoo
{
    public partial class FeatureFooController : Controller
    {
        public virtual ActionResult Index()
        {
            return View();
        }

        public virtual ActionResult Foobar(string param)
        {
            return View();
        }
    }
}