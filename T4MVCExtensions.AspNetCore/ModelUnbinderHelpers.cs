using Microsoft.AspNet.Routing;

namespace Microsoft.AspNet.Mvc
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
