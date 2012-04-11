using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Mvc.Ajax;

namespace T4MVCHostMvcApp.Areas.Break.Controllers {

    public class MyParamObject {
        public string Name { get; set; }
        public int Age { get; set; }
    }

    public partial class PostController : MyAbstractBaseController {
        public PostController(string s)
            : base(s) { }

        public virtual ActionResult Index() {
            return View();
        }

        public virtual ActionResult ActionWithBindPrefixAttribute([Bind(Prefix = "newParamName")] string fieldName) {
            return View();
        }

        public virtual ActionResult ActionWithBindNoPrefixAttribute([Bind] string fieldName) {
            return View();
        }

        public virtual ActionResult ActionThatTakesAnObject(MyParamObject p) {
            return View();
        }

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
