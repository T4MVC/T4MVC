using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace T4MVCHostMvcApp.Misc {
    public enum Animal {
        Dog,
        Cat
    }

    public class MyCustomResult : ActionResult {
        public MyCustomResult(string name, int num, Animal animal) {

        }
        public override void ExecuteResult(ControllerContext context) {
            throw new NotImplementedException();
        }
    }
}
