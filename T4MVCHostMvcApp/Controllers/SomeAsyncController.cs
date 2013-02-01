using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Web.Mvc;
using T4MVCHostMvcApp.Misc;

namespace T4MVCHostMvcApp.Controllers
{
    [HandleError]
    public partial class SomeAsyncController : AsyncController
    {
        public virtual ActionResult SomeAction()
        {
            return new EmptyResult();
        }

        [SuppressMessage("Microsoft.Performance", "CA1822:MarkMembersAsStatic")]
        public void GetSomethingAsync()
        {
        }

        // This async completion method is ignored by T4MVC, as it can't make use of it meaningfully
        public virtual JsonResult GetSomethingCompleted(string clientDocuments)
        {
            return new JsonResult();
        }

        [SuppressMessage("Microsoft.Design", "CA1026:DefaultParametersShouldNotBeUsed"), SuppressMessage("Microsoft.Performance", "CA1822:MarkMembersAsStatic"), SuppressMessage("Microsoft.Usage", "CA1801:ReviewUnusedParameters", MessageId = "id")]
        public void ActionWithDefaultsAsync(long? id = null)
        {
        }

        [SuppressMessage("Microsoft.Performance", "CA1822:MarkMembersAsStatic"), SuppressMessage("Microsoft.Usage", "CA1801:ReviewUnusedParameters", MessageId = "result")]
        public ActionResult ActionWithDefaultsCompleted(object result)
        {
            return null;
        }
    }
}
