using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.Routing;

namespace System.Web.Mvc
{
    public class PropertiesUnbinder : IModelUnbinder
    {
        public virtual void UnbindModel(RouteValueDictionary routeValueDictionary, string routeName, object routeValue)
        {
            var dict = new RouteValueDictionary(routeValue);
            foreach (var entry in dict)
            {
                var name = entry.Key;

                if (!(entry.Value is string) && (entry.Value is System.Collections.IEnumerable))
                {
                    var enumerableValue = (System.Collections.IEnumerable)entry.Value;
                    var i = 0;
                    foreach (var enumerableElement in enumerableValue)
                    {
                        ModelUnbinderHelpers.AddRouteValues(routeValueDictionary, string.Format("{0}.{1}[{2}]", routeName, name, i), enumerableElement);
                        i++;
                    }
                }
                else
                {
                    ModelUnbinderHelpers.AddRouteValues(routeValueDictionary, routeName + "." + name, entry.Value);
                }
            }
        }
    }
}
