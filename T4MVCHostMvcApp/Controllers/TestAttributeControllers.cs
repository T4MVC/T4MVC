using System;
using System.Web.Mvc;

namespace T4MVCHostMvcApp.Controllers {



  //
  // these are tests for the [T4MVC] attribute
  // look for the results under the T4MVC.tt node
  // those with "YES" should appear, those with "NO" should not
  //



  /// test regular controllers' names ...................................................................

  // this controller should be processed, and its "Controller" substring removed
  public partial class TestAttribute_YES_Name1Controller : Controller { }

  // this controller should not be processed, as it doesn't have a "Controller" suffix and doesn't use the attribute
  public partial class TestAttribute_NO_ControllerName2 : Controller { }

  // this controller should be processed, and its "Controller" substring removed even though it's not a suffix, because it uses the attribute
  [T4MVC]
  public partial class TestAttribute_YES_ControllerName3 : Controller { }


  /// test regular controllers ..........................................................................

  // this controller should not be processed
  [T4MVC(false)]
  public partial class TestAttribute_NO_IgnoredController : Controller { }

  // this controller should be processed
  [T4MVC]
  public partial class TestAttribute_YES_Processed1Controller : Controller { }

  // this controller should be processed
  [T4MVC(true)]
  public partial class TestAttribute_YES_Processed2Controller : Controller { }

  // this is not a controller, and should not be processed even though it has the attribute
  [T4MVC(true)]
  public partial class TestAttribute_NO_NotAController { }



  /// test abstract controllers ..........................................................................

  // this controller should not be processed as it's abstract and does not have the attribute
  public abstract partial class TestAttribute_NO_Abstract1Controller : Controller {
    public virtual ActionResult dostuff() { return View(); }
  }

  // this controller should be processed as it's abstract but has the attribute
  [T4MVC]
  public abstract partial class TestAttribute_YES_Abstract2Controller : Controller {
    public virtual ActionResult dostuff() { return View(); }
  }

  // this controller should be processed, and its ".generated.cs" class should not show 0108 "hides inherited member" warnings
  [T4MVC]
  public partial class TestAttribute_YES_DerivedController : TestAttribute_YES_Abstract2Controller {
    public override ActionResult dostuff() { return View(); }
  }


}