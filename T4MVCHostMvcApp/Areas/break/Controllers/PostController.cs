using System.Diagnostics.CodeAnalysis;
using System.Web.Mvc;

namespace T4MVCHostMvcApp.Areas.Break.Controllers
{

    [SuppressMessage("Microsoft.Naming", "CA1704:IdentifiersShouldBeSpelledCorrectly", MessageId = "Param")]
    public class MyParamObject
    {
        public string Name { get; set; }
        public int Age { get; set; }
    }

    public partial class PostController : MyAbstractBaseController
    {
        [SuppressMessage("Microsoft.Naming", "CA1704:IdentifiersShouldBeSpelledCorrectly", MessageId = "s", Scope = "member", Target = "T4MVCHostMvcApp.Areas.Break.Controllers.PostController.#.ctor(System.String)")]
        public PostController(string s)
            : base(s) { }

        public virtual ActionResult Index()
        {
            return View();
        }

        public virtual ActionResult ActionWithBindPrefixAttribute([Bind(Prefix = "newParamName")] string fieldName)
        {
            return View();
        }

        public virtual ActionResult ActionWithBindNoPrefixAttribute([Bind] string fieldName)
        {
            return View();
        }

        [SuppressMessage("Microsoft.Naming", "CA1704:IdentifiersShouldBeSpelledCorrectly", MessageId = "p")]
        public virtual ActionResult ActionThatTakesAnObject(MyParamObject p)
        {
            return View();
        }

        [SuppressMessage("Microsoft.Naming", "CA1720:IdentifiersShouldNotContainTypeNames", MessageId = "string"), System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1720:IdentifiersShouldNotContainTypeNames", MessageId = "object"), System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1720:IdentifiersShouldNotContainTypeNames", MessageId = "int"), System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1704:IdentifiersShouldBeSpelledCorrectly", MessageId = "Params")]
        public virtual ActionResult ActionWithVariousParams(string myString, int someInt, object someObject)
        {
            return View();
        }

        public override ActionResult CompiledControllerVirtualMethod2(string s)
        {
            return base.CompiledControllerVirtualMethod2(s);
        }
    }
}
