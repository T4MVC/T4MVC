using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using T4MVCHostMvcApp.Misc;

namespace T4MVCHostMvcApp.Controllers {
    [HandleError]
    public partial class HomeController : Controller {
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

        public virtual ActionResult ActionWithArrayParam(string[] someStrings) {
            return new EmptyResult();
        }

        public virtual ActionResult ActionWithAllOptionalParams(string someString = "Hello", int n = 5) {
            return new EmptyResult();
        }

        public virtual ActionResult ActionWithSomeOptionalParams(string someString, int n = 5) {
            return new EmptyResult();
        }

        public virtual ActionResult ActionWithGenericParam<T>(string someString) {
            return new EmptyResult();
        }

        public void GetSomethingAsync() {
        }

        // This async completion method is ignored by T4MVC, as it can't make use of it meaningfully
        public virtual JsonResult GetSomethingCompleted(string clientDocuments) {
            return new JsonResult();
        }

        [Obsolete]
        public virtual ActionResult SomeObsoleteAction() {
            return new EmptyResult();
        }

        public virtual ActionResult ActionWithParamUsingAtSyntax(int @event) {
            return new EmptyResult();
        }

        [Dummy(ActionNameConstants.ActionThatUsesActionNameConstantInAttribute)]
        public virtual ActionResult ActionThatUsesActionNameConstantInAttribute() {
            return new EmptyResult();
        }

        [RequireHttps]
        public virtual ActionResult ActionThatRequiresHttps(string someString)
        {
            return new EmptyResult();
        }
    }

    sealed class DummyAttribute : Attribute {
        public DummyAttribute(string actionName) {
        }
    }
}
