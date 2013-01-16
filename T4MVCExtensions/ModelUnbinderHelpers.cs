using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Routing;

namespace System.Web.Mvc
{
    public class ModelUnbinderHelpers
    {
        public static void AddRouteValues(RouteValueDictionary routeValueDictionary, string routeName, object routeValue)
        {
            IModelUnbinder unbinder = DefaultModelUnbinder;
            if (routeValue != null)
            {
                unbinder = ModelUnbinders.FindUnbinderFor(routeValue.GetType()) ?? (ModelUnbinderProviders.FindUnbinderFor(routeValue.GetType()) ?? DefaultModelUnbinder);
            }
            unbinder.UnbindModel(routeValueDictionary, routeName, routeValue);
        }

        private static readonly ModelUnbinders _modelUnbinders = new ModelUnbinders();
        public static ModelUnbinders ModelUnbinders
        {
            get { return _modelUnbinders; }
        }

        private static readonly ModelUnbinderProviders _modelUnbinderProviders = new ModelUnbinderProviders();
        public static ModelUnbinderProviders ModelUnbinderProviders
        {
            get { return _modelUnbinderProviders; }
        }

        public static IModelUnbinder DefaultModelUnbinder { get; set; }
        static ModelUnbinderHelpers()
        {
            DefaultModelUnbinder = new DefaultModelUnbinder();
        }
    }
}
