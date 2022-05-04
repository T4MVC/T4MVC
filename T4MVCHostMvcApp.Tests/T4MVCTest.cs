using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading;
using System.Web.Mvc;
using System.Web.Routing;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using T4MVCHostMvcApp.Controllers;

namespace T4MVCHostMvcApp.Tests
{
    /// <summary>
    ///This is a test class for T4ExtensionsTest and is intended
    ///to contain all T4ExtensionsTest Unit Tests
    ///</summary>
    [TestClass()]
    public class T4MVCTest
    {
        private TestContext testContextInstance;
        private static HtmlHelper Html { get; set; }

        // Change to true if testing 'UseLowercaseRoutes = true' mode (in T4MVC.settings.t4)
        static bool UseLowerCaseNames = false;

        /// <summary>
        ///Gets or sets the test context which provides
        ///information about and functionality for the current test run.
        ///</summary>
        public TestContext TestContext
        {
            get
            {
                return testContextInstance;
            }
            set
            {
                testContextInstance = value;
            }
        }


        class TestViewDataContainer : IViewDataContainer
        {
            #region IViewDataContainer Members

            public ViewDataDictionary ViewData
            {
                get
                {
                    throw new System.NotImplementedException();
                }
                set
                {
                    throw new System.NotImplementedException();
                }
            }

            #endregion
        }


        [ClassInitialize()]
        public static void MyClassInitialize(TestContext testContext)
        {
            T4MVCHelpers.ProcessVirtualPath = ProcessVirtualPath;

            Html = new HtmlHelper(new ViewContext(), new TestViewDataContainer());
        }


        // API TESTS

        [TestMethod()]
        public void TestInitMVCT4Result()
        {
            var result = (IT4MVCActionResult)MVC.Home.About();
            string area = "some area";
            string controller = "some controller";
            string action = "some action";
            T4Extensions.InitMVCT4Result(result, area, controller, action);

            Assert.AreEqual(controller, result.Controller);
            Assert.AreEqual(controller, result.RouteValueDictionary["controller"]);
            Assert.AreEqual(action, result.Action);
            Assert.AreEqual(action, result.RouteValueDictionary["action"]);
            Assert.AreEqual(area, result.RouteValueDictionary["area"]);
        }


        // AREA NAMES TESTS

        [TestMethod()]
        public void TestAreaNameConstants()
        {
            TestAreaControllerActionName("Home", MVC.HomeArea.Name);
            TestAreaControllerActionName("break", MVC.@break.Name);
        }

        [TestMethod()]
        public void TestAreaNameConstantsViewController()
        {
            TestAreaControllerActionName("", MVC.T4Ctrl.Area);
            TestAreaControllerActionName("Home", MVC.HomeArea.Home.Area);
            TestAreaControllerActionName("break", MVC.@break.Post.Area);
        }


        // CONTROLLER NAMES TESTS

        [TestMethod()]
        public void TestControllerName()
        {
            TestAreaControllerActionName("Home", MVC.Home.Name);
        }

        [TestMethod()]
        public void TestAreaControllerName()
        {
            TestAreaControllerActionName("Home", MVC.HomeArea.Home.Name);
            TestAreaControllerActionName("Post", MVC.@break.Post.Name);
        }

        [TestMethod()]
        public void TestT4SubFolderControllerName()
        {
            TestAreaControllerActionName("T4Ctrl", MVC.T4Ctrl.Name);
        }


        // ACTION NAMES TESTS

        [TestMethod()]
        public void TestSimpleActionName()
        {
            TestAreaControllerActionName("Index", MVC.Home.ActionNames.Index);
            TestAreaControllerActionName("Index", HomeController.ActionNameConstants.Index);
        }

        [TestMethod()]
        public void TestRenamedActionName()
        {
            TestAreaControllerActionName("The About Action", MVC.Home.ActionNames.About);
            TestAreaControllerActionName("New-Name for Blah", MVC.Home.ActionNames.Blah);
            TestAreaControllerActionName("The About Action", HomeController.ActionNameConstants.About);
            TestAreaControllerActionName("New-Name for Blah", HomeController.ActionNameConstants.Blah);
        }

        [TestMethod()]
        public void TestT4SubFolderControlleActionName()
        {
            TestAreaControllerActionName("Qqq", MVC.T4Ctrl.ActionNames.Qqq);
            TestAreaControllerActionName("Qqq", T4CtrlController.ActionNameConstants.Qqq);
        }

        [TestMethod()]
        public void TestAreaActionName()
        {
            TestAreaControllerActionName("The Index", MVC.HomeArea.Home.ActionNames.Index);
            TestAreaControllerActionName("The Index", T4MVCHostMvcApp.Areas.Home.Controllers.HomeController.ActionNameConstants.Index);
        }

        // PARAMETER NAMES TESTS

        [TestMethod()]
        public void TestParameterName()
        {
            Assert.AreEqual("myString", MVC.@break.Post.ActionWithVariousParamsParams.myString);
            Assert.AreEqual("someInt", MVC.@break.Post.ActionWithVariousParamsParams.someInt);
            Assert.AreEqual("someObject", MVC.@break.Post.ActionWithVariousParamsParams.someObject);
            Assert.AreEqual("someString", MVC.Home.OverloadedActionWithDifferentParamsParams.someString);
            Assert.AreEqual("someNumber", MVC.Home.OverloadedActionWithDifferentParamsParams.someNumber);
        }


        // VIEW PATHS TESTS

        [TestMethod()]
        public void TestSimpleViewName()
        {
            Assert.AreEqual("~/Views/Home/Index.aspx", MVC.Home.Views.Index);
            Assert.AreEqual("Index", MVC.Home.Views.ViewNames.Index);
        }

        [TestMethod()]
        public void TestConflictingViewNames()
        {
            Assert.AreEqual("~/Views/Home/Qqq.txt", MVC.Home.Views.Qqq);
            Assert.AreEqual("Qqq", MVC.Home.Views.ViewNames.Qqq);
            Assert.AreEqual("~/Views/Home/QqQ.txt2", MVC.Home.Views.QqQ);
            Assert.AreEqual("QqQ", MVC.Home.Views.ViewNames.QqQ);
            Assert.AreEqual("~/Views/Home/Qqq.txt3", MVC.Home.Views.Qqq_txt3);
            Assert.AreEqual("Qqq_txt3", MVC.Home.Views.ViewNames.Qqq_txt3);
        }

        [TestMethod()]
        public void TestComplexViewName()
        {
            Assert.AreEqual("~/Views/Home/7 Some Home.View-Hello.txt", MVC.Home.Views._7_Some_Home_View_Hello);
            Assert.AreEqual("7 Some Home.View-Hello", MVC.Home.Views.ViewNames._7_Some_Home_View_Hello);
        }

        [TestMethod()]
        public void TestNestedViewName()
        {
            Assert.AreEqual("~/Views/Home/Qqq.Nested.txt", MVC.Home.Views.Qqq_Nested);
            Assert.AreEqual("~/Views/Home/Qqq.Nested.Again.txt", MVC.Home.Views.Qqq_Nested_Again);
        }

        [TestMethod()]
        public void TestNestedViewNameWithSameNameAsParentFolder()
        {
            Assert.AreEqual("~/Views/Home/Sub Home/Qqq.txt", MVC.Home.Views.Sub_Home.Qqq);
            Assert.AreEqual("Qqq", MVC.Home.Views.Sub_Home.ViewNames.Qqq);
        }

        [TestMethod()]
        public void TestViewNameMatchingLanguageKeyword()
        {
            Assert.AreEqual("~/Views/Home/Sub Home/string.txt", MVC.Home.Views.Sub_Home.@string);
            Assert.AreEqual("string", MVC.Home.Views.Sub_Home.ViewNames.@string);
        }

        [TestMethod()]
        public void TestSuperNestedViewWithComplexName()
        {
            Assert.AreEqual("~/Views/Home/Sub Home/Nested-Sub/99 Super~Nested-View.txt", MVC.Home.Views.Sub_Home.Nested_Sub._99_Super_Nested_View);
            Assert.AreEqual("99 Super~Nested-View", MVC.Home.Views.Sub_Home.Nested_Sub.ViewNames._99_Super_Nested_View);
        }

        [TestMethod()]
        public void TestViewThatGeneratesFile()
        {
            Assert.AreEqual("~/Views/Home/Sub Home/T4View.tt", MVC.Home.Views.Sub_Home.T4View);
            Assert.AreEqual("T4View", MVC.Home.Views.Sub_Home.ViewNames.T4View);
        }

        [TestMethod()]
        public void TestSharedView()
        {
            Assert.AreEqual("~/Views/Shared/LogOnUserControl.ascx", MVC.Shared.Views.LogOnUserControl);
            Assert.AreEqual("LogOnUserControl", MVC.Shared.Views.ViewNames.LogOnUserControl);
        }

        [TestMethod()]
        public void TestAreaView()
        {
            Assert.AreEqual("~/Areas/Home/Views/Home/SomeHomeView.txt", MVC.HomeArea.Home.Views.SomeHomeView);
            Assert.AreEqual("SomeHomeView", MVC.HomeArea.Home.Views.ViewNames.SomeHomeView);
        }

        [TestMethod()]
        public void TestAreaSharedView()
        {
            Assert.AreEqual("~/Areas/break/Views/Shared/SharedAreaView.txt", MVC.@break.Shared.Views.SharedAreaView);
            Assert.AreEqual("SharedAreaView", MVC.@break.Shared.Views.ViewNames.SharedAreaView);
        }

        [TestMethod()]
        public void TestViewFolderWithNoMatchingController()
        {
            Assert.AreEqual("~/Views/NoControllerMatchingFolder.Foo/Abcd.txt", MVC.NoControllerMatchingFolder_Foo.Views.Abcd);
            Assert.AreEqual("Abcd", MVC.NoControllerMatchingFolder_Foo.Views.ViewNames.Abcd);
        }

        [TestMethod()]
        public void TestTemplateFolders()
        {
            Assert.AreEqual("SomeDisplayTemplate", MVC.Home.Views.DisplayTemplates.SomeDisplayTemplate);
            Assert.AreEqual("SomeEditorTemplate", MVC.Home.Views.EditorTemplates.SomeEditorTemplate);
            Assert.AreEqual("SomeAreaEditorTemplate", MVC.HomeArea.Home.Views.EditorTemplates.SomeAreaEditorTemplate);
        }

        [TestMethod()]
        public void TestFeatureFolderDefaultArea()
        {
            Assert.AreEqual("", MVC.Pictures.Area);
            Assert.AreEqual("Index", MVC.Pictures.ActionNames.Index);
            Assert.AreEqual("Detail", MVC.Pictures.ActionNames.Detail);
            Assert.AreEqual("~/Features/Pictures/Index.txt", MVC.Pictures.Views.Index);
            Assert.AreEqual("Index", MVC.Pictures.Views.ViewNames.Index);
            Assert.AreEqual("/Features/Pictures/Index.txt", Links.Features.Pictures.Index_txt);
        }

        [TestMethod()]
        public void TestFeatureFolderAreaNames()
        {
            Assert.AreEqual("FeatureFolderArea", MVC.FeatureFolderArea.Name);
            Assert.AreEqual("FeatureFoo", MVC.FeatureFolderArea.FeatureFoo.Name);
            Assert.AreEqual("Index", MVC.FeatureFolderArea.FeatureFoo.ActionNames.Index);
            Assert.AreEqual("Foobar", MVC.FeatureFolderArea.FeatureFoo.ActionNames.Foobar);
            Assert.AreEqual("~/Areas/FeatureFolderArea/FeatureFoo/Index.txt", MVC.FeatureFolderArea.FeatureFoo.Views.Index);
            Assert.AreEqual("~/Areas/FeatureFolderArea/FeatureFoo/Foobar.txt", MVC.FeatureFolderArea.FeatureFoo.Views.Foobar);
            Assert.AreEqual("~/Areas/FeatureFolderArea/SharedViews/SharedView.txt", MVC.FeatureFolderArea.SharedViews.Views.SharedView);
        }

        [TestMethod()]
        public void TestFeatureFolderAreaLinks()
        {
            Assert.AreEqual("/Areas/FeatureFolderArea/FeatureFoo/Foobar.txt", Links.Areas.FeatureFolderArea.FeatureFoo.Foobar_txt);
            Assert.AreEqual("/Areas/FeatureFolderArea/SharedViews/SharedView.txt", Links.Areas.FeatureFolderArea.SharedViews.SharedView_txt);
        }

        [TestMethod()]
        public void TestLinkedView()
        {
            Assert.AreEqual("~/Views/Home/SomeLinkedFile.txt", MVC.Home.Views.SomeLinkedFile);
        }

        // ROUTE VALUES TESTS

        [TestMethod()]
        public void TestRouteValuesForDefaultAreaNoParamAction()
        {
            var actionRes = (IT4MVCActionResult)MVC.T4Ctrl.Qqq();

            TestAreaControllerActionNames(actionRes, "", "T4Ctrl", "Qqq");
        }

        [TestMethod()]
        public void TestRouteValuesForRenamedActionWithParams()
        {
            var actionRes = (IT4MVCActionResult)MVC.Home.Blah("Hello", 123);

            TestAreaControllerActionNames(actionRes, "", "Home", "New-Name for Blah");
            TestRouteValue(actionRes, "name", "Hello");
            TestRouteValue(actionRes, "age", 123);
        }

        [TestMethod()]
        public void TestRouteValuesForRenamedActionUsingGeneratedNoParamOverload()
        {
            var actionRes = (IT4MVCActionResult)MVC.Home.Blah();

            TestAreaControllerActionNames(actionRes, "", "Home", "New-Name for Blah");
            TestNoRouteValue(actionRes, "name");
            TestNoRouteValue(actionRes, "age");
        }

        [TestMethod()]
        public void TestDontGeneratedNoParamOverloadWhenAllParamsAreOptional()
        {
            var actionRes = (IT4MVCActionResult)MVC.Home.ActionWithAllOptionalParams();

            TestAreaControllerActionNames(actionRes, "", "Home", "ActionWithAllOptionalParams");

            TestRouteValue(actionRes, "someString", "Hello");
            TestRouteValue(actionRes, "n", 5);

            // Switch to these lines once https://github.com/T4MVC/T4MVC/issues/49 is addressed
            //TestNoRouteValue(actionRes, "someString");
            //TestNoRouteValue(actionRes, "n");
        }

        [TestMethod()]
        public void TestGeneratedNoParamOverloadWhenOnlySomeParamsAreOptional()
        {
            var actionRes = (IT4MVCActionResult)MVC.Home.ActionWithSomeOptionalParams();

            TestAreaControllerActionNames(actionRes, "", "Home", "ActionWithSomeOptionalParams");
            TestNoRouteValue(actionRes, "n");
        }

        [TestMethod()]
        public void TestOptionalParamWhenNotPassingItIn()
        {
            var actionRes = (IT4MVCActionResult)MVC.Home.ActionWithSomeOptionalParams("Hello", 7);

            TestRouteValue(actionRes, "someString", "Hello");
            TestRouteValue(actionRes, "n", 7);
        }

        // Disable until https://github.com/T4MVC/T4MVC/issues/49 is addressed
#if NOTYET
        [TestMethod()]
        public void TestOptionalParamWhenPassingInNonDefaultValue()
        {
            var actionRes = (IT4MVCActionResult)MVC.Home.ActionWithSomeOptionalParams("Hello");

            TestRouteValue(actionRes, "someString", "Hello");
            TestNoRouteValue(actionRes, "n");
        }

        [TestMethod()]
        public void TestOptionalParamWithNullValue()
        {
            var actionRes = (IT4MVCActionResult)MVC.Home.ActionWithOptionalParamDefaultingToNull(null);

            TestNoRouteValue(actionRes, "n");
        }

        [TestMethod()]
        public void TestOptionalParamWithDefaultValue()
        {
            var actionRes = (IT4MVCActionResult)MVC.Home.ActionWithOptionalParamDefaultingToDefaultValue(default(CancellationToken));

            TestNoRouteValue(actionRes, "cancellationToken");
        }

        [TestMethod()]
        public void TestOptionalParamWithDefaultValueContainingSpaces()
        {
            var actionRes = (IT4MVCActionResult)MVC.Home.ActionWithOptionalParamDefaultingToDefaultValueWithSpaces(default(CancellationToken));

            TestNoRouteValue(actionRes, "cancellationToken");
        }

        [TestMethod()]
        public void TestOptionalParamWithDefaultValueAndFullyQualifiedTypeName()
        {
            var actionRes = (IT4MVCActionResult)MVC.Home.ActionWithOptionalParamDefaultingToDefaultValueWithFullyQualifiedTypeName(default(CancellationToken));

            TestNoRouteValue(actionRes, "cancellationToken");
        }

        [TestMethod()]
        public void TestOptionalParamWithConstructedDefaultValue()
        {
            var actionRes = (IT4MVCActionResult)MVC.Home.ActionWithOptionalParamDefaultingToConstructedDefaultValue(default(CancellationToken));

            TestNoRouteValue(actionRes, "cancellationToken");
        }
#endif

        [TestMethod()]
        public void TestRouteValuesForParamUsingAtSyntax()
        {
            var actionRes = (IT4MVCActionResult)MVC.Home.ActionWithParamUsingAtSyntax(8);

            TestRouteValue(actionRes, "event", 8);
        }

#if NOTYET
        [TestMethod()]
        public void TestRouteValuesForActionWithObjectParam() {
            var actionRes = (IT4MVCActionResult)MVC.@break.Post.ActionThatTakesAnObject(
                new T4MVCHostMvcApp.Areas.Break.Controllers.MyParamObject() {
                    Name = "David",
                    Age = 123
                }
            );

            TestAreaControllerActionNames(actionRes, "break", "Post", "ActionThatTakesAnObject");
            TestRouteValue(actionRes, "Name", "David");
            TestRouteValue(actionRes, "Age", 111);
        }
#endif

        [TestMethod()]
        public void TestRouteValuesForActionWithBindPrefixAttrib()
        {
            var actionRes = (IT4MVCActionResult)MVC.@break.Post.ActionWithBindPrefixAttribute("Hello");

            TestAreaControllerActionNames(actionRes, "break", "Post", "ActionWithBindPrefixAttribute");
            TestRouteValue(actionRes, "newParamName", "Hello");
        }

        [TestMethod()]
        public void TestRouteValuesForActionWithBindNoPrefixAttrib()
        {
            var actionRes = (IT4MVCActionResult)MVC.@break.Post.ActionWithBindNoPrefixAttribute("Hello");

            TestAreaControllerActionNames(actionRes, "break", "Post", "ActionWithBindNoPrefixAttribute");
            TestRouteValue(actionRes, "fieldName", "Hello");
        }

        [TestMethod()]
        public void TestRouteValuesForActionWithArrayParam()
        {
            var strings = new string[] { "cat", "dog" };
            var actionRes = (IT4MVCActionResult)MVC.Home.ActionWithArrayParam(strings);

            TestAreaControllerActionNames(actionRes, "", "Home", "ActionWithArrayParam");
            TestRouteValue(actionRes, "someStrings", strings);
        }

        [TestMethod()]
        public void TestRouteValuesForAreaNoParamAction()
        {
            var actionRes = (IT4MVCActionResult)MVC.@break.Post.Index();

            TestAreaControllerActionNames(actionRes, "break", "Post", "Index");
        }

        [TestMethod()]
        public void TestRouteValuesForSameAssemblyBaseAction()
        {
            var actionRes = (IT4MVCActionResult)MVC.@break.Post.SameProjectBaseControllerMethod("Hello");

            TestAreaControllerActionNames(actionRes, "break", "Post", "SameProjectBaseControllerMethod");
            TestRouteValue(actionRes, "s", "Hello");
        }

        [TestMethod()]
        public void TestRouteValuesForCompiledBaseAction()
        {
            var actionRes = (IT4MVCActionResult)MVC.@break.Post.CompiledControllerVirtualMethod(17);

            TestAreaControllerActionNames(actionRes, "break", "Post", "CompiledControllerVirtualMethod");
            TestRouteValue(actionRes, "n", 17);
        }

        [TestMethod()]
        public void TestRouteValuesForDerivedBuiltInActionResultTypes()
        {
            var viewResultActionRes = (IT4MVCActionResult)MVC.Home.SomeViewResultAction();
            var jsonResultActionRes = (IT4MVCActionResult)MVC.Home.SomeJsonResultAction();
            var fileContentResultActionRes = (IT4MVCActionResult)MVC.Home.SomeFileContentResultAction();
            //var fileStreamResultActionRes = (IT4MVCActionResult)MVC.Home.SomeFileStreamResultAction();    // Throws null ref exception!
            var fileResultActionRes = (IT4MVCActionResult)MVC.Home.SomeFileResultAction();

            TestAreaControllerActionNames(viewResultActionRes, "", "Home", "SomeViewResultAction");
            TestAreaControllerActionNames(jsonResultActionRes, "", "Home", "SomeJsonResultAction");
            TestAreaControllerActionNames(fileContentResultActionRes, "", "Home", "SomeFileContentResultAction");
            //TestAreaControllerActionNames(fileStreamResultActionRes, "", "Home", "SomeFileStreamResultAction");
            TestAreaControllerActionNames(fileResultActionRes, "", "Home", "SomeFileResultAction");
        }

        [TestMethod()]
        public void TestRouteValuesForCustomActionResultType()
        {
            var actionRes = (IT4MVCActionResult)MVC.Home.SomeCustomResultAction();

            TestAreaControllerActionNames(actionRes, "", "Home", "SomeCustomResultAction");
        }

        [TestMethod()]
        public void TestRouteValuesForSomeTaskBasedActionResultType()
        {
            var actionRes = (IT4MVCActionResult)MVC.Home.SomeTaskBasedAction().Result;

            TestAreaControllerActionNames(actionRes, "", "Home", "SomeTaskBasedAction");
        }

        [TestMethod()]
        public void TestRouteValuesForSomeTaskBasedActionResultTypeWithParams()
        {
            var actionRes = (IT4MVCActionResult)MVC.Home.SomeTaskBasedActionWithParams(3).Result;

            TestAreaControllerActionNames(actionRes, "", "Home", "SomeTaskBasedActionWithParams");
            TestRouteValue(actionRes, "id", 3);
        }

        [TestMethod()]
        public void TestRouteValuesForTaskBasedActionsWithNonDefaultTypes()
        {
            var actionRes = (IT4MVCActionResult)MVC.Home.ActionWithJsonResult().Result;
            TestAreaControllerActionNames(actionRes, "", "Home", "ActionWithJsonResult");

            actionRes = (IT4MVCActionResult)MVC.Home.ActionWithPartialResult(3).Result;
            TestAreaControllerActionNames(actionRes, "", "Home", "ActionWithPartialResult");
            TestRouteValue(actionRes, "id", 3);
        }

        [TestMethod()]
        public void TestRouteValuesWithAddedValues()
        {
            var actionRes = (IT4MVCActionResult)MVC.Home.Index().AddRouteValues(new { foo1 = "bar", foo2 = 234 });

            TestAreaControllerActionNames(actionRes, "", "Home", "Index");
            TestRouteValue(actionRes, "foo1", "bar");
            TestRouteValue(actionRes, "foo2", 234);
        }

        [TestMethod()]
        public void TestRouteValuesWithAddedValue()
        {
            var actionRes = (IT4MVCActionResult)MVC.Home.Index().AddRouteValue("foo", "bar");

            TestAreaControllerActionNames(actionRes, "", "Home", "Index");
            TestRouteValue(actionRes, "foo", "bar");
        }

        [TestMethod()]
        public void TestRouteValuesWithAddedValuesUsingGeneratedNoParamOverload()
        {
            var actionRes = (IT4MVCActionResult)MVC.Home.Blah().AddRouteValue("name", "Hello").AddRouteValues(new { age = 123, foo = true });

            TestAreaControllerActionNames(actionRes, "", "Home", "New-Name for Blah");
            TestRouteValue(actionRes, "name", "Hello");
            TestRouteValue(actionRes, "age", 123);
            TestRouteValue(actionRes, "foo", true);
        }

        [TestMethod()]
        public void TestRouteValuesFromNameValueCollection()
        {
            var nameValueCollection = new NameValueCollection();
            nameValueCollection["key1"] = "val1";
            nameValueCollection["key2"] = "val2";
            nameValueCollection["key3"] = "val3";

            var actionRes = (IT4MVCActionResult)MVC.Home.Blah().AddRouteValue("name", "Hello").AddRouteValues(nameValueCollection);

            TestAreaControllerActionNames(actionRes, "", "Home", "New-Name for Blah");
            TestRouteValue(actionRes, "name", "Hello");
            TestRouteValue(actionRes, "key1", "val1");
            TestRouteValue(actionRes, "key2", "val2");
            TestRouteValue(actionRes, "key3", "val3");
        }

        [TestMethod()]
        public void TestRouteValuesForQueryStringThatContainsNullDoesNotCrash()
        {
            var nameValueCollection = new NameValueCollection();
            nameValueCollection["key1"] = "val1";
            nameValueCollection["key2"] = "val2";
            nameValueCollection.Add(null, string.Empty);

            var actionRes = (IT4MVCActionResult)MVC.Home.Blah().AddRouteValue("name", "Hello").AddRouteValues(nameValueCollection);

            TestAreaControllerActionNames(actionRes, "", "Home", "New-Name for Blah");
            TestRouteValue(actionRes, "name", "Hello");
            TestRouteValue(actionRes, "key1", "val1");
            TestRouteValue(actionRes, "key2", "val2");

        }

        [TestMethod()]
        [ExpectedExceptionAttribute(typeof(InvalidOperationException), "")]
        public void TestErrorHandlingWhenPassingRealControllerAction()
        {
            var controller = new T4MVCHostMvcApp.Controllers.HomeController();

            Html.ActionLink("Test", controller.SomeViewResultAction());
        }

        #region ModelUnbinder tests
        private void RegisterModelUnbinders()
        {
            ModelUnbinderHelpers.ModelUnbinders.Clear();
            ModelUnbinderHelpers.ModelUnbinders.Add(new UnbindModelUnbinder());
            ModelUnbinderHelpers.ModelUnbinders.Add(new BaseEntityUnbinder());
            ModelUnbinderHelpers.ModelUnbinders.Add(new UserEntityUnbinder());
        }

        [TestMethod()]
        public void TestRouteValuesWithSimpleUnbinderModel()
        {
            RegisterModelUnbinders();
            var actionRes = (IT4MVCActionResult)MVC.ModelUnbinder.TestUnbindModel(new UnbindModel() { Id = 2 });

            TestRouteValue(actionRes, "model", 2);
        }

        [TestMethod()]
        public void TestRouteValuesWithSimpleUnbinderModel_NullValue()
        {
            RegisterModelUnbinders();
            var actionRes = (IT4MVCActionResult)MVC.ModelUnbinder.TestUnbindModel(null);

            TestRouteValue(actionRes, "model", null);
        }

        [TestMethod()]
        public void TestRouteValuesWithUnbinder_BaseClassWithUnbinder()
        {
            RegisterModelUnbinders();
            var actionRes = (IT4MVCActionResult)MVC.ModelUnbinder.TestBaseClass(new BaseEntity() { Id = 2 });

            TestRouteValue(actionRes, "entity", 2);
        }
        [TestMethod()]
        public void TestRouteValuesWithUnbinder_ChildClassWithDifferentUnbinderThanParent()
        {
            RegisterModelUnbinders();
            var actionRes = (IT4MVCActionResult)MVC.ModelUnbinder.TestChildClass1(new UserEntity() { Id = 2, Login = "asd" });

            TestRouteValue(actionRes, "user", "asd");
        }
        [TestMethod()]
        public void TestRouteValuesWithUnbinder_ChildClassWithoutUnbinder_ShouldUseUnbinderForBaseClass()
        {
            RegisterModelUnbinders();
            var actionRes = (IT4MVCActionResult)MVC.ModelUnbinder.TestChildClass2(new AnotherChildEntity() { Id = 2 });

            TestRouteValue(actionRes, "child", 2);
        }

        [TestMethod()]
        public void TestRouteValuesWithUnbinder_PropertiesUnbinder()
        {
            RegisterModelUnbinders();
            ModelUnbinderHelpers.ModelUnbinders.Add(typeof(IComplexModel), new PropertiesUnbinder());

            var actionRes = (IT4MVCActionResult)MVC.ModelUnbinder.TestComplexModel(new ComplexModel()
            {
                One = new BaseEntity() { Id = 1 },
                Two = new BaseEntity() { Id = 2 },
                Three = "zxc",
            });

            TestRouteValue(actionRes, "model.One", 1);
            TestRouteValue(actionRes, "model.Two", 2);
            TestRouteValue(actionRes, "model.Three", "zxc");
        }

        [TestMethod()]
        public void TestRouteValuesWithUnbinder_ComplexModelWithEnumerable()
        {
            RegisterModelUnbinders();
            ModelUnbinderHelpers.ModelUnbinders.Add(typeof(IComplexModel), new PropertiesUnbinder());

            var model = new ComplexModelWithEnumerable()
            {
                String = "stt",
                Ints = new List<int>() { 1, 2 },
                One = new[] { new BaseEntity() { Id = 6 }, new BaseEntity() { Id = 5 }, },
            };
            var actionRes = (IT4MVCActionResult)MVC.ModelUnbinder.TestComplexModelWithEnumerable(model);

            TestRouteValue(actionRes, "model.String", "stt");
            TestRouteValue(actionRes, "model.Ints[0]", 1);
            TestRouteValue(actionRes, "model.Ints[1]", 2);
            TestRouteValue(actionRes, "model.One[0]", 6);
            TestRouteValue(actionRes, "model.One[1]", 5);
        }

        [TestMethod()]
        public void Unbinder_AddRouteValue()
        {
            RegisterModelUnbinders();

            var actionRes = (IT4MVCActionResult)MVC.ModelUnbinder.ParameterlessAction()
                .AddRouteValue("tst", new UnbindModel() { Id = 2 });

            TestRouteValue(actionRes, "tst", 2);
        }

        [TestMethod()]
        public void Unbinder_AddRouteValues_Object()
        {
            RegisterModelUnbinders();

            var actionRes = (IT4MVCActionResult)MVC.ModelUnbinder.ParameterlessAction()
                .AddRouteValues(new { tst = new UnbindModel() { Id = 2 } });

            TestRouteValue(actionRes, "tst", 2);
        }

        [TestMethod()]
        public void Unbinder_AddRouteValues_RouteValueDictionary()
        {
            RegisterModelUnbinders();

            var actionRes = (IT4MVCActionResult)MVC.ModelUnbinder.ParameterlessAction()
                .AddRouteValues(new RouteValueDictionary(new { tst = new UnbindModel() { Id = 2 } }));

            TestRouteValue(actionRes, "tst", 2);
        }

        [TestMethod()]
        public void Unbinder_AddRouteValues_NameValueCollection()
        {
            RegisterModelUnbinders();

            var actionRes = (IT4MVCActionResult)MVC.ModelUnbinder.ParameterlessAction()
                .AddRouteValues(new NameValueCollection() { { "tst", "2" } });

            TestRouteValue(actionRes, "tst", "2");
        }

        [TestMethod]
        public void AddRouteValue_Does_Not_Throw_When_Adding_Existing_Key()
        {
            var actionResult = MVC.Home.Index();
    
            var actionResult1 = actionResult.AddRouteValue("foo", "bar1");
            var actionResult2 = actionResult.AddRouteValue("foo", "bar2"); 
        }

        #endregion

        // STATIC FILES TESTS

        [TestMethod()]
        public void TestLinkWithComplexFileName()
        {
            Assert.AreEqual("/Content/7 My.Text-File Space.txt", Links.Content._7_My_Text_File_Space_txt);
        }

        [TestMethod()]
        public void TestLinkInFolderNamedAfterKeyword()
        {
            Assert.AreEqual("/Content/default/Zzz.txt", Links.Content.@default.Zzz_txt);
        }

        [TestMethod()]
        public void TestLinkToT4File()
        {
            Assert.AreEqual("/Content/Sub Content-folder.test/SomeT4.tt", Links.Content.Sub_Content_folder_test.SomeT4_tt);
        }

        [TestMethod()]
        public void TestLinkToTextFileOutsideOfTheRootFolder()
        {
            Assert.AreEqual("/ContentStatic/TextFiles/readme.txt", Links.ContentStatic.TextFiles.readme_txt);
        }

        [TestMethod()]
        public void TestScriptFile()
        {
            Assert.AreEqual("/Scripts/jquery-1.3.2.js", Links.Scripts.jquery_1_3_2_js);
        }

        [TestMethod()]
        public void TestCssFile()
        {
            Assert.AreEqual("/Content/StyleSheet.css", Links.Content.StyleSheet_css);
        }

        [TestMethod()]
        public void TestCssFileInHomeArea()
        {
            Assert.AreEqual("/Areas/Home/Content/Home.css", Links.Areas.Home.Content.Home_css);
        }

        [TestMethod()]
        public void TestBundleFile()
        {
            Assert.AreEqual("~/Content/Site.css", Links.Bundles.Content.Assets.Site_css);
        }

        [TestMethod()]
        public void TestBundleFileInHomeArea()
        {
            Assert.AreEqual("~/Areas/Home/Content/Home.css", Links.Bundles.Areas.Home.Content.Assets.Home_css);
        }

        [TestMethod()]
        public void TestNoLinkGeneratedForIgnoredExtension()
        {
            var field = typeof(Links.Content).GetField("ShouldNotBeALink_cs");

            Assert.AreEqual(null, field);
        }

        [TestMethod()]
        public void TestNoPublicClassesinGlobalNamespace()
        {
            Type mvcType = typeof (MVC);

            foreach (Type type in mvcType.Assembly.GetTypes())
            {
                //Since we can change the name of this class via the settings file, this one is okay
                if (type == mvcType)
                {
                    continue;
                }

                if (String.IsNullOrEmpty(type.Namespace) && type.IsPublic)
                {
                    Assert.Fail("Public class in global namespace present: {0}", type.FullName);
                }
            }
        }

        // HELPER METHODS

        private void TestAreaControllerActionNames(IT4MVCActionResult actionResult, string area, string controller, string action)
        {
            if (UseLowerCaseNames)
            {
                area = area.ToLowerInvariant();
                controller = controller.ToLowerInvariant();
                action = action.ToLowerInvariant();
            }

            if (!string.IsNullOrEmpty(area))
                TestRouteValue(actionResult, "area", area);
            else
                TestNoRouteValue(actionResult, "area");

            TestRouteValue(actionResult, "controller", controller);
            TestRouteValue(actionResult, "action", action);
        }

        private void TestAreaControllerActionName(string expected, string actual)
        {
            if (UseLowerCaseNames)
            {
                expected = expected.ToLowerInvariant();
            }

            Assert.AreEqual(expected, actual);
        }

        private void TestRouteValue(IT4MVCActionResult actionResult, string name, object value)
        {
            Assert.IsTrue(actionResult.RouteValueDictionary.ContainsKey(name));
            Assert.AreEqual(value, actionResult.RouteValueDictionary[name]);
        }

        private void TestNoRouteValue(IT4MVCActionResult actionResult, string name)
        {
            Assert.IsFalse(actionResult.RouteValueDictionary.ContainsKey(name));
        }

        private static string ProcessVirtualPath(string virtualPath)
        {
            // The path that comes in starts with ~/ and must first be made absolute
            if (virtualPath.StartsWith("~/"))
                virtualPath = virtualPath.Substring(1);

            return virtualPath;
        }
    }
}
