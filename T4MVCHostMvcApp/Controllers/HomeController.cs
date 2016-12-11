﻿using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Threading;
using System.Threading.Tasks;
using System.Web.Mvc;
using SomeNamespace;
using T4MVCHostMvcApp.Misc;
namespace T4MVCHostMvcApp.Controllers
{

    [HandleError]
    public partial class HomeController : Controller
    {
        [SuppressMessage("Microsoft.Performance", "CA1810:InitializeReferenceTypeStaticFieldsInline", Scope = "member", Target = "T4MVCHostMvcApp.Controllers.HomeController.#.cctor()")]
        static HomeController() { }

        public virtual async Task<ActionResult> AsyncTask()
        {
            await Task.Run(() => System.Diagnostics.Debug.WriteLine("ignored"));

            return View(new object());
        }

        public virtual ActionResult Index()
        {
            //RedirectToAction()

            ViewData["Message"] = "Welcome to ASP.NET MVC!";

            return View();
        }

        const string firstConst = "The About";
        const string secondConst = "Action";
        [ActionName(firstConst + " " + secondConst)]
        public virtual ActionResult About()
        {
            return RedirectToAction(Actions.Index());
        }

        [SuppressMessage("Microsoft.Performance", "CA1804:RemoveUnusedLocals", MessageId = "ageParamName"), SuppressMessage("Microsoft.Performance", "CA1804:RemoveUnusedLocals", MessageId = "nameParamName"), ActionName("New-Name for Blah")]
        public virtual ActionResult Blah(string name, int age)
        {
            // Just checking that the short syntax for param names works
            string nameParamName = BlahParams.name;
            string ageParamName = BlahParams.age;

            return View();
        }

        public virtual void SomeVoidAction()
        {
        }

        public virtual ViewResult SomeViewResultAction()
        {
            return new ViewResult();
        }

        public virtual JsonResult SomeJsonResultAction()
        {
            return null;
        }

        public virtual FileContentResult SomeFileContentResultAction()
        {
            return null;
        }

        public virtual FileStreamResult SomeFileStreamResultAction()
        {
            return null;
        }

        public virtual FileResult SomeFileResultAction()
        {
            return null;
        }

        public virtual MyCustomResult SomeCustomResultAction()
        {
            return null;
        }

        [SuppressMessage("Microsoft.Naming", "CA1704:IdentifiersShouldBeSpelledCorrectly", MessageId = "Param"), SuppressMessage("Microsoft.Naming", "CA1720:IdentifiersShouldNotContainTypeNames", MessageId = "strings")]
        public virtual ActionResult ActionWithArrayParam(string[] someStrings)
        {
            return new EmptyResult();
        }

        [SuppressMessage("Microsoft.Design", "CA1026:DefaultParametersShouldNotBeUsed"), SuppressMessage("Microsoft.Naming", "CA1704:IdentifiersShouldBeSpelledCorrectly", MessageId = "Params"), SuppressMessage("Microsoft.Naming", "CA1704:IdentifiersShouldBeSpelledCorrectly", MessageId = "n"), SuppressMessage("Microsoft.Naming", "CA1720:IdentifiersShouldNotContainTypeNames", MessageId = "string")]
        public virtual ActionResult ActionWithAllOptionalParams(string someString = "Hello", int n = 5)
        {
            return new EmptyResult();
        }

        [SuppressMessage("Microsoft.Design", "CA1026:DefaultParametersShouldNotBeUsed"), SuppressMessage("Microsoft.Naming", "CA1704:IdentifiersShouldBeSpelledCorrectly", MessageId = "Params"), SuppressMessage("Microsoft.Naming", "CA1704:IdentifiersShouldBeSpelledCorrectly", MessageId = "n"), SuppressMessage("Microsoft.Naming", "CA1720:IdentifiersShouldNotContainTypeNames", MessageId = "string")]
        public virtual ActionResult ActionWithSomeOptionalParams(string someString, int n = 5)
        {
            return new EmptyResult();
        }

        [SuppressMessage("Microsoft.Naming", "CA1704:IdentifiersShouldBeSpelledCorrectly", MessageId = "Param"), SuppressMessage("Microsoft.Design", "CA1026:DefaultParametersShouldNotBeUsed"), SuppressMessage("Microsoft.Naming", "CA1704:IdentifiersShouldBeSpelledCorrectly", MessageId = "Params"), SuppressMessage("Microsoft.Naming", "CA1704:IdentifiersShouldBeSpelledCorrectly", MessageId = "n"), SuppressMessage("Microsoft.Naming", "CA1720:IdentifiersShouldNotContainTypeNames", MessageId = "string")]
        public virtual ActionResult ActionWithOptionalParamDefaultingToNull(int? n = null)
        {
            return new EmptyResult();
        }

        [SuppressMessage("Microsoft.Naming", "CA1704:IdentifiersShouldBeSpelledCorrectly", MessageId = "Param"), SuppressMessage("Microsoft.Design", "CA1026:DefaultParametersShouldNotBeUsed"), SuppressMessage("Microsoft.Naming", "CA1704:IdentifiersShouldBeSpelledCorrectly", MessageId = "Params"), SuppressMessage("Microsoft.Naming", "CA1720:IdentifiersShouldNotContainTypeNames", MessageId = "string")]
        public virtual ActionResult ActionWithOptionalParamDefaultingToDefaultValue(CancellationToken cancellationToken = default(CancellationToken))
        {
            return new EmptyResult();
        }

        [SuppressMessage("Microsoft.Naming", "CA1704:IdentifiersShouldBeSpelledCorrectly", MessageId = "Param"), SuppressMessage("Microsoft.Design", "CA1026:DefaultParametersShouldNotBeUsed"), SuppressMessage("Microsoft.Naming", "CA1704:IdentifiersShouldBeSpelledCorrectly", MessageId = "Params"), SuppressMessage("Microsoft.Naming", "CA1720:IdentifiersShouldNotContainTypeNames", MessageId = "string")]
        public virtual ActionResult ActionWithOptionalParamDefaultingToDefaultValueWithFullyQualifiedTypeName(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            return new EmptyResult();
        }

        [SuppressMessage("Microsoft.Naming", "CA1704:IdentifiersShouldBeSpelledCorrectly", MessageId = "Param"), SuppressMessage("Microsoft.Design", "CA1026:DefaultParametersShouldNotBeUsed"), SuppressMessage("Microsoft.Naming", "CA1704:IdentifiersShouldBeSpelledCorrectly", MessageId = "Params"), SuppressMessage("Microsoft.Naming", "CA1720:IdentifiersShouldNotContainTypeNames", MessageId = "string")]
        public virtual ActionResult ActionWithOptionalParamDefaultingToDefaultValueWithSpaces(CancellationToken cancellationToken = default ( CancellationToken ) )
        {
            return new EmptyResult();
        }

        [SuppressMessage("Microsoft.Naming", "CA1704:IdentifiersShouldBeSpelledCorrectly", MessageId = "Param"), SuppressMessage("Microsoft.Design", "CA1026:DefaultParametersShouldNotBeUsed"), SuppressMessage("Microsoft.Naming", "CA1704:IdentifiersShouldBeSpelledCorrectly", MessageId = "Params"), SuppressMessage("Microsoft.Naming", "CA1720:IdentifiersShouldNotContainTypeNames", MessageId = "string")]
        public virtual ActionResult ActionWithOptionalParamDefaultingToConstructedDefaultValue(CancellationToken cancellationToken = new CancellationToken())
        {
            return new EmptyResult();
        }

#if !USE_ROUTE_ATTRIBUTES
        // can't use MVC RouteAttributes with generic actions
        [SuppressMessage("Microsoft.Design", "CA1004:GenericMethodsShouldProvideTypeParameter"), SuppressMessage("Microsoft.Naming", "CA1704:IdentifiersShouldBeSpelledCorrectly", MessageId = "Param"), SuppressMessage("Microsoft.Naming", "CA1720:IdentifiersShouldNotContainTypeNames", MessageId = "string")]
        public virtual ActionResult ActionWithGenericParam<T>(string someString)
        {
            return new EmptyResult();
        }
#endif

        [SuppressMessage("Microsoft.Design", "CA1041:ProvideObsoleteAttributeMessage")]
        [Obsolete]
        public virtual ActionResult SomeObsoleteAction()
        {
            return new EmptyResult();
        }

        [SuppressMessage("Microsoft.Naming", "CA1704:IdentifiersShouldBeSpelledCorrectly", MessageId = "Param"), SuppressMessage("Microsoft.Naming", "CA1716:IdentifiersShouldNotMatchKeywords", MessageId = "event")]
        public virtual ActionResult ActionWithParamUsingAtSyntax(int @event)
        {
            return new EmptyResult();
        }

        [Dummy(ActionNameConstants.ActionThatUsesActionNameConstantInAttribute)]
        public virtual ActionResult ActionThatUsesActionNameConstantInAttribute()
        {
            return new EmptyResult();
        }

        [SuppressMessage("Microsoft.Naming", "CA1720:IdentifiersShouldNotContainTypeNames", MessageId = "string")]
        [RequireHttps]
        public virtual ActionResult ActionThatRequiresHttps(string someString)
        {
            return new EmptyResult();
        }

        [SuppressMessage("Microsoft.Naming", "CA1704:IdentifiersShouldBeSpelledCorrectly", MessageId = "Params"), SuppressMessage("Microsoft.Naming", "CA1720:IdentifiersShouldNotContainTypeNames", MessageId = "string")]
        public virtual ActionResult OverloadedActionWithDifferentParams(string someString)
        {
            return new EmptyResult();
        }

        [SuppressMessage("Microsoft.Naming", "CA1704:IdentifiersShouldBeSpelledCorrectly", MessageId = "Params")]
        public virtual ActionResult OverloadedActionWithDifferentParams(int someNumber)
        {
            return new EmptyResult();
        }

        public virtual SomeGenericResult<string> ActionReturningGenericResultString()
        {
            throw new NotImplementedException();
        }

        public virtual SomeGenericResult<int> ActionReturningGenericResultInt()
        {
            throw new NotImplementedException();
        }

        [SuppressMessage("Microsoft.Design", "CA1006:DoNotNestGenericTypesInMemberSignatures")]
        public virtual SomeGenericResult<List<Tuple<string, string, int>>> ActionReturningGenericResultNested()
        {
            throw new NotImplementedException();
        }

        public virtual Task<ActionResult> SomeTaskBasedAction()
        {
            return Task.FromResult(new EmptyResult() as ActionResult);
        }

        [SuppressMessage("Microsoft.Naming", "CA1704:IdentifiersShouldBeSpelledCorrectly", MessageId = "Params")]
        public virtual Task<ActionResult> SomeTaskBasedActionWithParams(int id)
        {
            return Task.FromResult(new EmptyResult() as ActionResult);
        }

        public virtual Task<JsonResult> ActionWithJsonResult()
        {
            throw new NotImplementedException();
        }

        public virtual Task<PartialViewResult> ActionWithPartialResult(int id)
        {
            throw new NotImplementedException();
        }

        const double multipleRate = 1.2;

        [SuppressMessage("Microsoft.Design", "CA1026:DefaultParametersShouldNotBeUsed")]
        public virtual ActionResult ActionUsingPrivateFieldForDefaultValue(double rate = multipleRate)
        {
            throw new NotImplementedException();
        }

        [SuppressMessage("Microsoft.Design", "CA1026:DefaultParametersShouldNotBeUsed")]
        public virtual ActionResult ActionUsingEnumDeclaredInOtherNamespace(JobType jobType = JobType.First)
        {
            return View();
        }

        public virtual ViewResultBase SomeAbstractResult()
        {
            throw new NotImplementedException();
        }

        public virtual ActionResult ManyControllers()
        {
            return View();
        }
    }

    public class SomeGenericResult<T> : FileResult
    {
        public SomeGenericResult(string contentType)
            : base(contentType)
        {

        }
        protected override void WriteFile(System.Web.HttpResponseBase response)
        {
            throw new NotImplementedException();
        }
    }

    sealed class DummyAttribute : Attribute
    {
        [SuppressMessage("Microsoft.Usage", "CA1801:ReviewUnusedParameters", MessageId = "actionName")]
        public DummyAttribute(string actionName)
        {
        }
    }

    partial class T4MVC_HomeController
    {
        public override ActionResult Blah()
        {
            var callInfo = base.Blah();
            return callInfo;
        }

        partial void AboutOverride(T4MVC_System_Web_Mvc_ActionResult callInfo)
        {
            callInfo.RouteValueDictionary["stub"] = "Extra Text in route";
        }
    }
}

namespace SomeNamespace
{
    public enum JobType
    {
        First,
        Second
    }
}
