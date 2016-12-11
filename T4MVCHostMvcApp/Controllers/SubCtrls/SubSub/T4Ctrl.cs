using System.Diagnostics.CodeAnalysis;
using System.Web.Mvc;

namespace T4MVCHostMvcApp.Controllers {
    public partial class T4CtrlController : Controller
    {

        public T4CtrlController() {

        }

        [SuppressMessage("Microsoft.Naming", "CA1704:IdentifiersShouldBeSpelledCorrectly", MessageId = "Qqq")]
        public virtual ActionResult Qqq()
        {
            return new EmptyResult();
        }
    }
}
