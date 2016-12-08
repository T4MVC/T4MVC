using System;
using System.Diagnostics.CodeAnalysis;
using System.Linq.Expressions;
using System.Web.Mvc;
using SomeClassLibrary;

namespace T4MVCHostMvc5App.Areas.Break.Controllers
{
    [SuppressMessage("Microsoft.Design", "CA1012:AbstractTypesShouldNotHaveConstructors")]
    public abstract partial class MyAbstractBaseController : SomeCompiledBaseController
    {
        [SuppressMessage("Microsoft.Usage", "CA1801:ReviewUnusedParameters", MessageId = "s"), System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1704:IdentifiersShouldBeSpelledCorrectly", MessageId = "s")]
        public MyAbstractBaseController(string s)
        {

        }

        [SuppressMessage("Microsoft.Naming", "CA1704:IdentifiersShouldBeSpelledCorrectly", MessageId = "s")]
        public virtual ActionResult SameProjectBaseControllerMethod(string s)
        {
            return new EmptyResult();
        }

        [SuppressMessage("Microsoft.Performance", "CA1822:MarkMembersAsStatic")]
        protected T SomeGenericMethod<T>()
        {
            return default(T);
        }

        // T4MVC will ignore these two methods because of the [NonAction] attribute
        [SuppressMessage("Microsoft.Design", "CA1006:DoNotNestGenericTypesInMemberSignatures")]
        [NonAction]
        protected virtual RedirectToRouteResult RedirectToAction<TController>(Expression<Action<TController>> action) where TController : Controller
        {
            return null;
        }
        [NonAction]
        public virtual new ViewResult View(string viewName)
        {
            return null;
        }
    }
}
