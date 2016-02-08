using Microsoft.AspNet.Html.Abstractions;
using Microsoft.AspNet.Mvc.Rendering;
using Microsoft.AspNet.Mvc.ViewFeatures;
using Microsoft.AspNet.Routing;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading.Tasks;

namespace Microsoft.AspNet.Mvc {
    public static class GenericT4Extensions {
        public static IHtmlContent ActionLink<TActionResult>(this IHtmlHelper htmlHelper, string linkText, Task<TActionResult> taskResult) where TActionResult : ActionResult {
            return T4Extensions.ActionLink(htmlHelper, linkText, taskResult.Result, (IDictionary<string, object>)null, (string)null, (string)null, (string)null);
        }

        public static IHtmlContent ActionLink<TActionResult>(this IHtmlHelper htmlHelper, string linkText, Task<TActionResult> taskResult, object htmlAttributes) where TActionResult : ActionResult {
            return T4Extensions.ActionLink(htmlHelper, linkText, taskResult.Result, htmlAttributes, (string)null, (string)null, (string)null);
        }

        public static IHtmlContent ActionLink<TActionResult>(this IHtmlHelper htmlHelper, string linkText, Task<TActionResult> taskResult, object htmlAttributes, string protocol) where TActionResult : ActionResult {
            return T4Extensions.ActionLink(htmlHelper, linkText, taskResult.Result, htmlAttributes, protocol, (string)null, (string)null);
        }

        public static IHtmlContent ActionLink<TActionResult>(this IHtmlHelper htmlHelper, string linkText, Task<TActionResult> taskResult, object htmlAttributes, string protocol, string hostName) where TActionResult : ActionResult {
            return T4Extensions.ActionLink(htmlHelper, linkText, taskResult.Result, htmlAttributes, protocol, hostName, (string)null);
        }

        // TODO
        //public static IHtmlContent ActionLink<TActionResult>(this IHtmlHelper htmlHelper, string linkText, Task<TActionResult> taskResult, object htmlAttributes, string protocol, string hostName, string fragment) where TActionResult : ActionResult {
        //    return LinkExtensions.RouteLink(htmlHelper, linkText, (string)null, protocol ?? T4Extensions.GetT4MVCResult(taskResult.Result).Protocol, hostName, fragment, T4Extensions.GetRouteValueDictionary(taskResult.Result), (IDictionary<string, object>)HtmlHelper.AnonymousObjectToHtmlAttributes(htmlAttributes));
        //}

        public static IHtmlContent ActionLink<TActionResult>(this IHtmlHelper htmlHelper, string linkText, Task<TActionResult> taskResult, IDictionary<string, object> htmlAttributes) where TActionResult : ActionResult {
            return T4Extensions.ActionLink(htmlHelper, linkText, taskResult.Result, htmlAttributes, (string)null, (string)null, (string)null);
        }

        public static IHtmlContent ActionLink<TActionResult>(this IHtmlHelper htmlHelper, string linkText, Task<TActionResult> taskResult, IDictionary<string, object> htmlAttributes, string protocol) where TActionResult : ActionResult {
            return T4Extensions.ActionLink(htmlHelper, linkText, taskResult.Result, htmlAttributes, protocol, (string)null, (string)null);
        }

        public static IHtmlContent ActionLink<TActionResult>(this IHtmlHelper htmlHelper, string linkText, Task<TActionResult> taskResult, IDictionary<string, object> htmlAttributes, string protocol, string hostName) where TActionResult : ActionResult {
            return T4Extensions.ActionLink(htmlHelper, linkText, taskResult.Result, htmlAttributes, protocol, hostName, (string)null);
        }

        // TODO
        //public static IHtmlContent ActionLink<TActionResult>(this IHtmlHelper htmlHelper, string linkText, Task<TActionResult> taskResult, IDictionary<string, object> htmlAttributes, string protocol, string hostName, string fragment) where TActionResult : ActionResult {
        //    return LinkExtensions.RouteLink(htmlHelper, linkText, (string)null, protocol ?? T4Extensions.GetT4MVCResult(taskResult.Result).Protocol, hostName, fragment, T4Extensions.GetRouteValueDictionary(taskResult.Result), htmlAttributes);
        //}

        public static IHtmlContent RouteLink<TActionResult>(this IHtmlHelper htmlHelper, string linkText, Task<TActionResult> taskResult, object htmlAttributes) where TActionResult : ActionResult {
            return T4Extensions.RouteLink(htmlHelper, linkText, (string)null, taskResult.Result, htmlAttributes, (string)null, (string)null, (string)null);
        }

        public static IHtmlContent RouteLink<TActionResult>(this IHtmlHelper htmlHelper, string linkText, string routeName, Task<TActionResult> taskResult, object htmlAttributes) where TActionResult : ActionResult {
            return T4Extensions.RouteLink(htmlHelper, linkText, routeName, taskResult.Result, htmlAttributes, (string)null, (string)null, (string)null);
        }

        public static IHtmlContent RouteLink<TActionResult>(this IHtmlHelper htmlHelper, string linkText, string routeName, Task<TActionResult> taskResult, object htmlAttributes, string protocol) where TActionResult : ActionResult {
            return T4Extensions.RouteLink(htmlHelper, linkText, routeName, taskResult.Result, htmlAttributes, protocol, (string)null, (string)null);
        }

        public static IHtmlContent RouteLink<TActionResult>(this IHtmlHelper htmlHelper, string linkText, string routeName, Task<TActionResult> taskResult, object htmlAttributes, string protocol, string hostName) where TActionResult : ActionResult {
            return T4Extensions.RouteLink(htmlHelper, linkText, routeName, taskResult.Result, htmlAttributes, protocol, hostName, (string)null);
        }

        public static IHtmlContent RouteLink<TActionResult>(this IHtmlHelper htmlHelper, string linkText, string routeName, Task<TActionResult> taskResult, object htmlAttributes, string protocol, string hostName, string fragment) where TActionResult : ActionResult {
            return T4Extensions.RouteLink(htmlHelper, linkText, routeName, taskResult.Result, (IDictionary<string, object>)HtmlHelper.AnonymousObjectToHtmlAttributes(htmlAttributes), protocol, hostName, fragment);
        }

        public static IHtmlContent RouteLink<TActionResult>(this IHtmlHelper htmlHelper, string linkText, Task<TActionResult> taskResult, IDictionary<string, object> htmlAttributes) where TActionResult : ActionResult {
            return T4Extensions.RouteLink(htmlHelper, linkText, (string)null, taskResult.Result, htmlAttributes, (string)null, (string)null, (string)null);
        }

        public static IHtmlContent RouteLink<TActionResult>(this IHtmlHelper htmlHelper, string linkText, string routeName, Task<TActionResult> taskResult, IDictionary<string, object> htmlAttributes) where TActionResult : ActionResult {
            return T4Extensions.RouteLink(htmlHelper, linkText, routeName, taskResult.Result, htmlAttributes, (string)null, (string)null, (string)null);
        }

        public static IHtmlContent RouteLink<TActionResult>(this IHtmlHelper htmlHelper, string linkText, string routeName, Task<TActionResult> taskResult, IDictionary<string, object> htmlAttributes, string protocol) where TActionResult : ActionResult {
            return T4Extensions.RouteLink(htmlHelper, linkText, routeName, taskResult.Result, htmlAttributes, protocol, (string)null, (string)null);
        }

        public static IHtmlContent RouteLink<TActionResult>(this IHtmlHelper htmlHelper, string linkText, string routeName, Task<TActionResult> taskResult, IDictionary<string, object> htmlAttributes, string protocol, string hostName) where TActionResult : ActionResult {
            return T4Extensions.RouteLink(htmlHelper, linkText, routeName, taskResult.Result, htmlAttributes, protocol, hostName, (string)null);
        }

        public static IHtmlContent RouteLink<TActionResult>(this IHtmlHelper htmlHelper, string linkText, string routeName, Task<TActionResult> taskResult, IDictionary<string, object> htmlAttributes, string protocol, string hostName, string fragment) where TActionResult : ActionResult {
            return T4Extensions.RouteLink(htmlHelper, linkText, routeName, taskResult.Result, htmlAttributes, protocol, hostName, fragment);
        }

        public static MvcForm BeginForm<TActionResult>(this IHtmlHelper htmlHelper, Task<TActionResult> taskResult) where TActionResult : ActionResult {
            return T4Extensions.BeginForm(htmlHelper, taskResult.Result, FormMethod.Post);
        }

        public static MvcForm BeginForm<TActionResult>(this IHtmlHelper htmlHelper, Task<TActionResult> taskResult, FormMethod formMethod) where TActionResult : ActionResult {
            return T4Extensions.BeginForm(htmlHelper, taskResult.Result, formMethod, (IDictionary<string, object>)null);
        }

        public static MvcForm BeginForm<TActionResult>(this IHtmlHelper htmlHelper, Task<TActionResult> taskResult, FormMethod formMethod, object htmlAttributes) where TActionResult : ActionResult {
            return T4Extensions.BeginForm(htmlHelper, taskResult.Result, formMethod, (IDictionary<string, object>)HtmlHelper.AnonymousObjectToHtmlAttributes(htmlAttributes));
        }

        public static MvcForm BeginForm<TActionResult>(this IHtmlHelper htmlHelper, Task<TActionResult> taskResult, FormMethod formMethod, IDictionary<string, object> htmlAttributes) where TActionResult : ActionResult {
            return T4Extensions.BeginForm(htmlHelper, taskResult.Result, formMethod, htmlAttributes);
        }

        public static MvcForm BeginRouteForm<TActionResult>(this IHtmlHelper htmlHelper, Task<TActionResult> taskResult) where TActionResult : ActionResult {
            return T4Extensions.BeginRouteForm(htmlHelper, (string)null, taskResult.Result, FormMethod.Post, (IDictionary<string, object>)null);
        }

        public static MvcForm BeginRouteForm<TActionResult>(this IHtmlHelper htmlHelper, string routeName, Task<TActionResult> taskResult) where TActionResult : ActionResult {
            return T4Extensions.BeginRouteForm(htmlHelper, routeName, taskResult.Result, FormMethod.Post, (IDictionary<string, object>)null);
        }

        public static MvcForm BeginRouteForm<TActionResult>(this IHtmlHelper htmlHelper, string routeName, Task<TActionResult> taskResult, FormMethod method) where TActionResult : ActionResult {
            return T4Extensions.BeginRouteForm(htmlHelper, routeName, taskResult.Result, method, (IDictionary<string, object>)null);
        }

        public static MvcForm BeginRouteForm<TActionResult>(this IHtmlHelper htmlHelper, string routeName, Task<TActionResult> taskResult, FormMethod method, object htmlAttributes) where TActionResult : ActionResult {
            return T4Extensions.BeginRouteForm(htmlHelper, routeName, taskResult.Result, method, (IDictionary<string, object>)HtmlHelper.AnonymousObjectToHtmlAttributes(htmlAttributes));
        }

        public static MvcForm BeginRouteForm<TActionResult>(this IHtmlHelper htmlHelper, string routeName, Task<TActionResult> taskResult, FormMethod method, IDictionary<string, object> htmlAttributes) where TActionResult : ActionResult {
            return T4Extensions.BeginRouteForm(htmlHelper, routeName, taskResult.Result, method, htmlAttributes);
        }

        public static string RouteUrl<TActionResult>(this IUrlHelper urlHelper, Task<TActionResult> taskResult) where TActionResult : ActionResult {
            return T4Extensions.RouteUrl(urlHelper, (string)null, taskResult.Result, (string)null, (string)null);
        }

        public static string RouteUrl<TActionResult>(this IUrlHelper urlHelper, string routeName, Task<TActionResult> taskResult) where TActionResult : ActionResult {
            return T4Extensions.RouteUrl(urlHelper, routeName, taskResult.Result, (string)null, (string)null);
        }

        public static string RouteUrl<TActionResult>(this IUrlHelper urlHelper, string routeName, Task<TActionResult> taskResult, string protocol) where TActionResult : ActionResult {
            return T4Extensions.RouteUrl(urlHelper, routeName, taskResult.Result, protocol, (string)null);
        }

        public static string RouteUrl<TActionResult>(this IUrlHelper urlHelper, string routeName, Task<TActionResult> taskResult, string protocol, string hostName) where TActionResult : ActionResult {
            return T4Extensions.RouteUrl(urlHelper, routeName, taskResult.Result, protocol, hostName);
        }

        public static IRouteBuilder MapRoute<TActionResult>(this IRouteBuilder routes, string name, string url, Task<TActionResult> taskResult) where TActionResult : ActionResult {
            return T4Extensions.MapRoute(routes, name, url, taskResult.Result, (string[])null);
        }

        public static IRouteBuilder MapRoute<TActionResult>(this IRouteBuilder routes, string name, string url, Task<TActionResult> taskResult, object defaults) where TActionResult : ActionResult {
            return T4Extensions.MapRoute(routes, name, url, taskResult.Result, defaults, (object)null, (string[])null);
        }

        public static IRouteBuilder MapRoute<TActionResult>(this IRouteBuilder routes, string name, string url, Task<TActionResult> taskResult, string[] namespaces) where TActionResult : ActionResult {
            return T4Extensions.MapRoute(routes, name, url, taskResult.Result, (object)null, namespaces);
        }

        public static IRouteBuilder MapRoute<TActionResult>(this IRouteBuilder routes, string name, string url, Task<TActionResult> taskResult, object defaults, object constraints) where TActionResult : ActionResult {
            return T4Extensions.MapRoute(routes, name, url, taskResult.Result, defaults, constraints, (string[])null);
        }

        public static IRouteBuilder MapRoute<TActionResult>(this IRouteBuilder routes, string name, string url, Task<TActionResult> taskResult, object defaults, string[] namespaces) where TActionResult : ActionResult {
            return T4Extensions.MapRoute(routes, name, url, taskResult.Result, defaults, (object)null, namespaces);
        }

        public static IRouteBuilder MapRoute<TActionResult>(this IRouteBuilder routes, string name, string url, Task<TActionResult> taskResult, object defaults, object constraints, string[] namespaces) where TActionResult : ActionResult {
            return T4Extensions.MapRoute(routes, name, url, taskResult.Result, defaults, constraints, namespaces);
        }

        public static IRouteBuilder MapRouteArea<TActionResult>(this IRouteBuilder routes, string areaName, string name, string url, Task<TActionResult> taskResult) where TActionResult : ActionResult {
            return T4Extensions.MapRouteArea(routes, areaName, name, url, taskResult.Result, (string[])null);
        }

        public static IRouteBuilder MapRouteArea<TActionResult>(this IRouteBuilder routes, string areaName, string name, string url, Task<TActionResult> taskResult, object defaults) where TActionResult : ActionResult {
            return T4Extensions.MapRouteArea(routes, areaName, name, url, taskResult.Result, defaults, (object)null, (string[])null);
        }

        public static IRouteBuilder MapRouteArea<TActionResult>(this IRouteBuilder routes, string areaName, string name, string url, Task<TActionResult> taskResult, string[] namespaces) where TActionResult : ActionResult {
            return T4Extensions.MapRouteArea(routes, areaName, name, url, taskResult.Result, (object)null, namespaces);
        }

        public static IRouteBuilder MapRouteArea<TActionResult>(this IRouteBuilder routes, string areaName, string name, string url, Task<TActionResult> taskResult, object defaults, object constraints) where TActionResult : ActionResult {
            return T4Extensions.MapRouteArea(routes, areaName, name, url, taskResult.Result, defaults, constraints, (string[])null);
        }

        public static IRouteBuilder MapRouteArea<TActionResult>(this IRouteBuilder routes, string areaName, string name, string url, Task<TActionResult> taskResult, object defaults, string[] namespaces) where TActionResult : ActionResult {
            return T4Extensions.MapRouteArea(routes, areaName, name, url, taskResult.Result, defaults, (object)null, namespaces);
        }

        public static IRouteBuilder MapRouteArea<TActionResult>(this IRouteBuilder routes, string areaName, string name, string url, Task<TActionResult> taskResult, object defaults, object constraints, string[] namespaces) where TActionResult : ActionResult {
            return T4Extensions.MapRouteArea(routes, areaName, name, url, taskResult.Result, defaults, constraints, namespaces);
        }


        public static TActionResult AddRouteValues<TActionResult>(this TActionResult result, object routeValues) where TActionResult : ActionResult {
            return (TActionResult)T4Extensions.AddRouteValues(result, new RouteValueDictionary(routeValues));
        }
        public static TActionResult AddRouteValues<TActionResult>(this TActionResult result, RouteValueDictionary routeValues) where TActionResult : ActionResult {
            return (TActionResult)T4Extensions.AddRouteValues(result, routeValues);

        }
        public static TActionResult AddRouteValues<TActionResult>(this TActionResult result, NameValueCollection nameValueCollection) where TActionResult : ActionResult {
            return (TActionResult)T4Extensions.AddRouteValues(result, nameValueCollection);
        }
        public static TActionResult AddRouteValue<TActionResult>(this TActionResult result, string name, object value) where TActionResult : ActionResult {
            return (TActionResult)T4Extensions.AddRouteValue(result, name, value);

        }


        public static Task<TResult> AddRouteValues<TResult>(this Task<TResult> action, object routeValues) where TResult : ActionResult {
            return AddRouteValues(action, new RouteValueDictionary(routeValues));
        }
        public static Task<TResult> AddRouteValues<TResult>(this Task<TResult> action, RouteValueDictionary routeValues) where TResult : ActionResult {
            return action.ContinueWith(t => t.Result.AddRouteValues(routeValues), TaskContinuationOptions.OnlyOnRanToCompletion | TaskContinuationOptions.ExecuteSynchronously);
        }
        public static Task<TResult> AddRouteValues<TResult>(this Task<TResult> action, NameValueCollection nameValueCollection) where TResult : ActionResult {
            return action.ContinueWith(t => t.Result.AddRouteValues(nameValueCollection), TaskContinuationOptions.OnlyOnRanToCompletion | TaskContinuationOptions.ExecuteSynchronously);
        }
        public static Task<TResult> AddRouteValue<TResult>(this Task<TResult> action, string name, object value) where TResult : ActionResult {
            return action.ContinueWith(t => t.Result.AddRouteValue(name, value), TaskContinuationOptions.OnlyOnRanToCompletion | TaskContinuationOptions.ExecuteSynchronously);
        }
    }

}
