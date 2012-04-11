using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.Mvc;

namespace SomeClassLibrary {
    // Note: we deliberately build the MVC app with a reference to the binary of this library
    // rather than a project reference, as that triggers difference VS behavior (e.g. OM can't modify the sources)
    public abstract class SomeCompiledBaseController : Controller {
        public ActionResult CompiledControllerNonVirtualMethod(int n) {
            return new EmptyResult();
        }

        public virtual ActionResult CompiledControllerVirtualMethod(int n) {
            return new EmptyResult();
        }

        public virtual ActionResult CompiledControllerVirtualMethod2(string s) {
            return new EmptyResult();
        }
    }
}
