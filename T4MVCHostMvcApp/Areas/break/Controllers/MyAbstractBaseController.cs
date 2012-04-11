using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using SomeClassLibrary;
using System.Web.Mvc;
using System.Linq.Expressions;

namespace T4MVCHostMvcApp.Areas.Break.Controllers {
    public abstract partial class MyAbstractBaseController : SomeCompiledBaseController {
        public MyAbstractBaseController(string s) {

        }

        public virtual ActionResult SameProjectBaseControllerMethod(string s) {
            return new EmptyResult();
        }

        public T SomeGenericMethod<T>() {
            return default(T);
        }

        // T4MVC will ignore these two methods because of the [NonAction] attribute
        [NonAction]
        public virtual RedirectToRouteResult RedirectToAction<TController>(Expression<Action<TController>> action) where TController : Controller {
            return null;
        }
        [NonAction]
        public virtual new ViewResult View(string viewName) {
            return null;
        }
    }
}
