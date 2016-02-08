using Microsoft.AspNet.Routing;

namespace Microsoft.AspNet.Mvc
{
    public class DefaultModelUnbinder : IModelUnbinder
    {
        public void UnbindModel(RouteValueDictionary routeValueDictionary, string routeName, object routeValue)
        {
            routeValueDictionary[routeName] =  routeValue;
        }
    }
}
