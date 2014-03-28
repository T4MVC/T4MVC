using System.Web.Mvc;

namespace T4MVCHostMvcApp.Areas.FeatureFolderArea.FeatureFoo
{
    public partial class FeatureFooController : Controller
    {
        public virtual ActionResult Index()
        {
            return View();
        }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1704:IdentifiersShouldBeSpelledCorrectly", MessageId = "Foobar")]
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1704:IdentifiersShouldBeSpelledCorrectly", MessageId = "param")]
        public virtual ActionResult Foobar(string param)
        {
            return View();
        }
    }
}