using System;
using System.Diagnostics.CodeAnalysis;
using System.Web.Mvc;
using T4MVCHostMvcApp.Misc;

namespace T4MVCHostMvcApp.Controllers {
    [HandleError]
    public partial class HomeController : Controller {
        [SuppressMessage("Microsoft.Performance", "CA1810:InitializeReferenceTypeStaticFieldsInline", Scope = "member", Target = "T4MVCHostMvcApp.Controllers.HomeController.#.cctor()")]
        static HomeController() { }

        public virtual ActionResult Index() {
            //RedirectToAction()

            ViewData["Message"] = "Welcome to ASP.NET MVC!";

            return View();
        }

        const string firstConst = "The About";
        const string secondConst = "Action";
        [ActionName(firstConst + " " + secondConst)]
        public virtual ActionResult About() {
            return RedirectToAction(Actions.Index());
        }

        [ActionName("New-Name for Blah")]
        public virtual ActionResult Blah(string name, int age) {
            return View();
        }

        public virtual void SomeVoidAction() {
        }

        public virtual ViewResult SomeViewResultAction() {
            return new ViewResult();
        }

        public virtual JsonResult SomeJsonResultAction() {
            return null;
        }

        public virtual FileContentResult SomeFileContentResultAction() {
            return null;
        }

        public virtual FileStreamResult SomeFileStreamResultAction() {
            return null;
        }

        public virtual FileResult SomeFileResultAction() {
            return null;
        }

        public virtual MyCustomResult SomeCustomResultAction() {
            return null;
        }

        [SuppressMessage("Microsoft.Naming", "CA1704:IdentifiersShouldBeSpelledCorrectly", MessageId = "Param"), System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1720:IdentifiersShouldNotContainTypeNames", MessageId = "strings")]
        public virtual ActionResult ActionWithArrayParam(string[] someStrings) {
            return new EmptyResult();
        }

        [SuppressMessage("Microsoft.Design", "CA1026:DefaultParametersShouldNotBeUsed"), System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1704:IdentifiersShouldBeSpelledCorrectly", MessageId = "Params"), System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1704:IdentifiersShouldBeSpelledCorrectly", MessageId = "n"), System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1720:IdentifiersShouldNotContainTypeNames", MessageId = "string")]
        public virtual ActionResult ActionWithAllOptionalParams(string someString = "Hello", int n = 5) {
            return new EmptyResult();
        }

        [SuppressMessage("Microsoft.Design", "CA1026:DefaultParametersShouldNotBeUsed"), System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1704:IdentifiersShouldBeSpelledCorrectly", MessageId = "Params"), System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1704:IdentifiersShouldBeSpelledCorrectly", MessageId = "n"), System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1720:IdentifiersShouldNotContainTypeNames", MessageId = "string")]
        public virtual ActionResult ActionWithSomeOptionalParams(string someString, int n = 5) {
            return new EmptyResult();
        }

        [SuppressMessage("Microsoft.Design", "CA1004:GenericMethodsShouldProvideTypeParameter"), System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1704:IdentifiersShouldBeSpelledCorrectly", MessageId = "Param"), System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1720:IdentifiersShouldNotContainTypeNames", MessageId = "string")]
        public virtual ActionResult ActionWithGenericParam<T>(string someString) {
            return new EmptyResult();
        }

        [SuppressMessage("Microsoft.Performance", "CA1822:MarkMembersAsStatic")]
        public void GetSomethingAsync() {
        }

        // This async completion method is ignored by T4MVC, as it can't make use of it meaningfully
        public virtual JsonResult GetSomethingCompleted(string clientDocuments) {
            return new JsonResult();
        }

        [SuppressMessage("Microsoft.Design", "CA1041:ProvideObsoleteAttributeMessage")]
        [Obsolete]
        public virtual ActionResult SomeObsoleteAction() {
            return new EmptyResult();
        }

        [SuppressMessage("Microsoft.Naming", "CA1704:IdentifiersShouldBeSpelledCorrectly", MessageId = "Param"), System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1716:IdentifiersShouldNotMatchKeywords", MessageId = "event")]
        public virtual ActionResult ActionWithParamUsingAtSyntax(int @event) {
            return new EmptyResult();
        }

        [Dummy(ActionNameConstants.ActionThatUsesActionNameConstantInAttribute)]
        public virtual ActionResult ActionThatUsesActionNameConstantInAttribute() {
            return new EmptyResult();
        }

        [SuppressMessage("Microsoft.Naming", "CA1720:IdentifiersShouldNotContainTypeNames", MessageId = "string")]
        [RequireHttps]
        public virtual ActionResult ActionThatRequiresHttps(string someString)
        {
            return new EmptyResult();
        }
    }

    sealed class DummyAttribute : Attribute {
        [SuppressMessage("Microsoft.Usage", "CA1801:ReviewUnusedParameters", MessageId = "actionName")]
        public DummyAttribute(string actionName) {
        }
    }
}
