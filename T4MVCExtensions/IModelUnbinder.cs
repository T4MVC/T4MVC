using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Routing;

namespace System.Web.Mvc
{
    public interface IModelUnbinder
    {
        void UnbindModel(RouteValueDictionary routeValueDictionary, string routeName, object routeValue);
    }

    public interface IModelUnbinder<in T> where T : class
    {
        void UnbindModel(RouteValueDictionary routeValueDictionary, string routeName, T routeValue);
    }
}
