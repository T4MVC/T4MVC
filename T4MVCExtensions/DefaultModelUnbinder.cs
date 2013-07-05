using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Routing;

namespace System.Web.Mvc
{
    public class DefaultModelUnbinder : IModelUnbinder
    {
        public void UnbindModel(RouteValueDictionary routeValueDictionary, string routeName, object routeValue)
        {
            routeValueDictionary[routeName] =  routeValue;
        }
    }
}
