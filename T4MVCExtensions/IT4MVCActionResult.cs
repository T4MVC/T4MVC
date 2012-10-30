using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Routing;

namespace System.Web.Mvc
{
    public interface IT4MVCActionResult
    {
        string Action { get; set; }
        string Controller { get; set; }
        RouteValueDictionary RouteValueDictionary { get; set; }
        string Protocol { get; set; }
    }
}
