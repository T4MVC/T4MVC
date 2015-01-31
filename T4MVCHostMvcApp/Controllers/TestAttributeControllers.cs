using System;
using System.Web.Mvc;

namespace T4MVCHostMvcApp.Controllers {



    //
    // these are tests for the [T4MVC] attribute
    // look for the results under the T4MVC.tt node
    // those with "Yes" should appear, those with "No" should not
    //



    /// test regular controllers' names ...................................................................

    // this controller should be processed, and its "Controller" substring removed
    public partial class TestAttributeYesName1Controller : Controller { }

    // this controller should not be processed, as it doesn't have a "Controller" suffix and doesn't use the attribute
    public partial class TestAttributeNoControllerName2 : Controller { }

    // this controller should be processed, and its "Controller" substring removed even though it's not a suffix, because it uses the attribute
    [T4MVC]
    public partial class TestAttributeYesControllerName3 : Controller { }


    /// test regular controllers ..........................................................................

    // this controller should not be processed
    [T4MVC(false)]
    public partial class TestAttributeNoIgnoredController : Controller { }

    // this controller should be processed
    [T4MVC]
    public partial class TestAttributeYesProcessed1Controller : Controller { }

    // this controller should be processed
    [T4MVC(true)]
    public partial class TestAttributeYesProcessed2Controller : Controller { }

    // this is not a controller, and should not be processed even though it has the attribute
    [T4MVC(true)]
    public partial class TestAttributeNoNotAController { }



    /// test abstract controllers ..........................................................................

    // this controller should not be processed as it's abstract and does not have the attribute
    public abstract partial class TestAttributeNoAbstract1Controller : Controller {
        public virtual ActionResult DoStuff() { return View(); }
    }

    // this controller should be processed as it's abstract but has the attribute
    [T4MVC]
    public abstract partial class TestAttributeYesAbstract2Controller : Controller {
        protected TestAttributeYesAbstract2Controller() { }
        public virtual ActionResult DoStuff() { return View(); }
    }

    // this controller should be processed, and its ".generated.cs" class should not show 0108 "hides inherited member" warnings
    [T4MVC]
    public partial class TestAttributeYesDerivedController : TestAttributeYesAbstract2Controller {
        public override ActionResult DoStuff() { return View(); }
    }



    // test generic controllers ..........................................................................

    // this controller should not be processed, as it's generic and the attribute was not applied
    public partial class TestAttributeNoGenericXController<T> : Controller {
        public virtual ActionResult DoStuffX() { return View(); }
    }

    // this controller should not be processed, as it's generic and the attribute was not applied
    public partial class TestAttributeNoGenericY1Controller<T> : TestAttributeNoGenericXController<T> {
        public virtual ActionResult DoStuffY() { return View(); }
    }

    // this controller should be processed since the attribute was applied
    [T4MVC]
    public partial class TestAttributeYesGenericY2Controller<T> : TestAttributeNoGenericXController<T> {
        public virtual ActionResult DoStuffY() { return View(); }
    }

    // this controller should always be processed, even without the attribute
    public partial class TestAttributeYesGenericZController : TestAttributeNoGenericY1Controller<DateTime> {
        public virtual ActionResult DoStuffZ() { return View(); }
    }



}