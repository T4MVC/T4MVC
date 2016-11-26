using Microsoft.AspNet.Routing;

namespace Microsoft.AspNet.Mvc
{
    public interface IT4MVCActionResult
    {
        string Action { get; set; }
        string Controller { get; set; }
        RouteValueDictionary RouteValueDictionary { get; set; }
        string Protocol { get; set; }
    }
}
