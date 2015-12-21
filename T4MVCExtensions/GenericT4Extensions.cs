using System.Collections.Generic;
using System.Threading.Tasks;
using System.Web.Mvc.Ajax;
using System.Web.Mvc.Html;
using System.Web.Routing;

namespace System.Web.Mvc {
    public static class GenericT4Extensions {
        public static MvcHtmlString ActionLink<TActionResult>(this HtmlHelper htmlHelper, string linkText, Task<TActionResult> taskResult) where TActionResult : ActionResult {
            return T4Extensions.ActionLink(htmlHelper, linkText, taskResult.Result, (IDictionary<string, object>)null, (string)null, (string)null, (string)null);
        }

        public static MvcHtmlString ActionLink<TActionResult>(this HtmlHelper htmlHelper, string linkText, Task<TActionResult> taskResult, object htmlAttributes) where TActionResult : ActionResult {
            return T4Extensions.ActionLink(htmlHelper, linkText, taskResult.Result, htmlAttributes, (string)null, (string)null, (string)null);
        }

        public static MvcHtmlString ActionLink<TActionResult>(this HtmlHelper htmlHelper, string linkText, Task<TActionResult> taskResult, object htmlAttributes, string protocol) where TActionResult : ActionResult {
            return T4Extensions.ActionLink(htmlHelper, linkText, taskResult.Result, htmlAttributes, protocol, (string)null, (string)null);
        }

        public static MvcHtmlString ActionLink<TActionResult>(this HtmlHelper htmlHelper, string linkText, Task<TActionResult> taskResult, object htmlAttributes, string protocol, string hostName) where TActionResult : ActionResult {
            return T4Extensions.ActionLink(htmlHelper, linkText, taskResult.Result, htmlAttributes, protocol, hostName, (string)null);
        }

        public static MvcHtmlString ActionLink<TActionResult>(this HtmlHelper htmlHelper, string linkText, Task<TActionResult> taskResult, object htmlAttributes, string protocol, string hostName, string fragment) where TActionResult : ActionResult {
            return LinkExtensions.RouteLink(htmlHelper, linkText, (string)null, protocol ?? T4Extensions.GetT4MVCResult(taskResult.Result).Protocol, hostName, fragment, T4Extensions.GetRouteValueDictionary(taskResult.Result), (IDictionary<string, object>)HtmlHelper.AnonymousObjectToHtmlAttributes(htmlAttributes));
        }

        public static MvcHtmlString ActionLink<TActionResult>(this HtmlHelper htmlHelper, string linkText, Task<TActionResult> taskResult, IDictionary<string, object> htmlAttributes) where TActionResult : ActionResult {
            return T4Extensions.ActionLink(htmlHelper, linkText, taskResult.Result, htmlAttributes, (string)null, (string)null, (string)null);
        }

        public static MvcHtmlString ActionLink<TActionResult>(this HtmlHelper htmlHelper, string linkText, Task<TActionResult> taskResult, IDictionary<string, object> htmlAttributes, string protocol) where TActionResult : ActionResult {
            return T4Extensions.ActionLink(htmlHelper, linkText, taskResult.Result, htmlAttributes, protocol, (string)null, (string)null);
        }

        public static MvcHtmlString ActionLink<TActionResult>(this HtmlHelper htmlHelper, string linkText, Task<TActionResult> taskResult, IDictionary<string, object> htmlAttributes, string protocol, string hostName) where TActionResult : ActionResult {
            return T4Extensions.ActionLink(htmlHelper, linkText, taskResult.Result, htmlAttributes, protocol, hostName, (string)null);
        }

        public static MvcHtmlString ActionLink<TActionResult>(this HtmlHelper htmlHelper, string linkText, Task<TActionResult> taskResult, IDictionary<string, object> htmlAttributes, string protocol, string hostName, string fragment) where TActionResult : ActionResult {
            return LinkExtensions.RouteLink(htmlHelper, linkText, (string)null, protocol ?? T4Extensions.GetT4MVCResult(taskResult.Result).Protocol, hostName, fragment, T4Extensions.GetRouteValueDictionary(taskResult.Result), htmlAttributes);
        }

        public static MvcHtmlString RouteLink<TActionResult>(this HtmlHelper htmlHelper, string linkText, Task<TActionResult> taskResult, object htmlAttributes) where TActionResult : ActionResult {
            return T4Extensions.RouteLink(htmlHelper, linkText, (string)null, taskResult.Result, htmlAttributes, (string)null, (string)null, (string)null);
        }

        public static MvcHtmlString RouteLink<TActionResult>(this HtmlHelper htmlHelper, string linkText, string routeName, Task<TActionResult> taskResult, object htmlAttributes) where TActionResult : ActionResult {
            return T4Extensions.RouteLink(htmlHelper, linkText, routeName, taskResult.Result, htmlAttributes, (string)null, (string)null, (string)null);
        }

        public static MvcHtmlString RouteLink<TActionResult>(this HtmlHelper htmlHelper, string linkText, string routeName, Task<TActionResult> taskResult, object htmlAttributes, string protocol) where TActionResult : ActionResult {
            return T4Extensions.RouteLink(htmlHelper, linkText, routeName, taskResult.Result, htmlAttributes, protocol, (string)null, (string)null);
        }

        public static MvcHtmlString RouteLink<TActionResult>(this HtmlHelper htmlHelper, string linkText, string routeName, Task<TActionResult> taskResult, object htmlAttributes, string protocol, string hostName) where TActionResult : ActionResult {
            return T4Extensions.RouteLink(htmlHelper, linkText, routeName, taskResult.Result, htmlAttributes, protocol, hostName, (string)null);
        }

        public static MvcHtmlString RouteLink<TActionResult>(this HtmlHelper htmlHelper, string linkText, string routeName, Task<TActionResult> taskResult, object htmlAttributes, string protocol, string hostName, string fragment) where TActionResult : ActionResult {
            return T4Extensions.RouteLink(htmlHelper, linkText, routeName, taskResult.Result, (IDictionary<string, object>)HtmlHelper.AnonymousObjectToHtmlAttributes(htmlAttributes), protocol, hostName, fragment);
        }

        public static MvcHtmlString RouteLink<TActionResult>(this HtmlHelper htmlHelper, string linkText, Task<TActionResult> taskResult, IDictionary<string, object> htmlAttributes) where TActionResult : ActionResult {
            return T4Extensions.RouteLink(htmlHelper, linkText, (string)null, taskResult.Result, htmlAttributes, (string)null, (string)null, (string)null);
        }

        public static MvcHtmlString RouteLink<TActionResult>(this HtmlHelper htmlHelper, string linkText, string routeName, Task<TActionResult> taskResult, IDictionary<string, object> htmlAttributes) where TActionResult : ActionResult {
            return T4Extensions.RouteLink(htmlHelper, linkText, routeName, taskResult.Result, htmlAttributes, (string)null, (string)null, (string)null);
        }

        public static MvcHtmlString RouteLink<TActionResult>(this HtmlHelper htmlHelper, string linkText, string routeName, Task<TActionResult> taskResult, IDictionary<string, object> htmlAttributes, string protocol) where TActionResult : ActionResult {
            return T4Extensions.RouteLink(htmlHelper, linkText, routeName, taskResult.Result, htmlAttributes, protocol, (string)null, (string)null);
        }

        public static MvcHtmlString RouteLink<TActionResult>(this HtmlHelper htmlHelper, string linkText, string routeName, Task<TActionResult> taskResult, IDictionary<string, object> htmlAttributes, string protocol, string hostName) where TActionResult : ActionResult {
            return T4Extensions.RouteLink(htmlHelper, linkText, routeName, taskResult.Result, htmlAttributes, protocol, hostName, (string)null);
        }

        public static MvcHtmlString RouteLink<TActionResult>(this HtmlHelper htmlHelper, string linkText, string routeName, Task<TActionResult> taskResult, IDictionary<string, object> htmlAttributes, string protocol, string hostName, string fragment) where TActionResult : ActionResult {
            return T4Extensions.RouteLink(htmlHelper, linkText, routeName, taskResult.Result, htmlAttributes, protocol, hostName, fragment);
        }

        public static MvcForm BeginForm<TActionResult>(this HtmlHelper htmlHelper, Task<TActionResult> taskResult) where TActionResult : ActionResult {
            return T4Extensions.BeginForm(htmlHelper, taskResult.Result, FormMethod.Post);
        }

        public static MvcForm BeginForm<TActionResult>(this HtmlHelper htmlHelper, Task<TActionResult> taskResult, FormMethod formMethod) where TActionResult : ActionResult {
            return T4Extensions.BeginForm(htmlHelper, taskResult.Result, formMethod, (IDictionary<string, object>)null);
        }

        public static MvcForm BeginForm<TActionResult>(this HtmlHelper htmlHelper, Task<TActionResult> taskResult, FormMethod formMethod, object htmlAttributes) where TActionResult : ActionResult {
            return T4Extensions.BeginForm(htmlHelper, taskResult.Result, formMethod, (IDictionary<string, object>)HtmlHelper.AnonymousObjectToHtmlAttributes(htmlAttributes));
        }

        public static MvcForm BeginForm<TActionResult>(this HtmlHelper htmlHelper, Task<TActionResult> taskResult, FormMethod formMethod, IDictionary<string, object> htmlAttributes) where TActionResult : ActionResult {
            return T4Extensions.BeginForm(htmlHelper, taskResult.Result, formMethod, htmlAttributes);
        }

        public static MvcForm BeginRouteForm<TActionResult>(this HtmlHelper htmlHelper, Task<TActionResult> taskResult) where TActionResult : ActionResult {
            return T4Extensions.BeginRouteForm(htmlHelper, (string)null, taskResult.Result, FormMethod.Post, (IDictionary<string, object>)null);
        }

        public static MvcForm BeginRouteForm<TActionResult>(this HtmlHelper htmlHelper, string routeName, Task<TActionResult> taskResult) where TActionResult : ActionResult {
            return T4Extensions.BeginRouteForm(htmlHelper, routeName, taskResult.Result, FormMethod.Post, (IDictionary<string, object>)null);
        }

        public static MvcForm BeginRouteForm<TActionResult>(this HtmlHelper htmlHelper, string routeName, Task<TActionResult> taskResult, FormMethod method) where TActionResult : ActionResult {
            return T4Extensions.BeginRouteForm(htmlHelper, routeName, taskResult.Result, method, (IDictionary<string, object>)null);
        }

        public static MvcForm BeginRouteForm<TActionResult>(this HtmlHelper htmlHelper, string routeName, Task<TActionResult> taskResult, FormMethod method, object htmlAttributes) where TActionResult : ActionResult {
            return T4Extensions.BeginRouteForm(htmlHelper, routeName, taskResult.Result, method, (IDictionary<string, object>)HtmlHelper.AnonymousObjectToHtmlAttributes(htmlAttributes));
        }

        public static MvcForm BeginRouteForm<TActionResult>(this HtmlHelper htmlHelper, string routeName, Task<TActionResult> taskResult, FormMethod method, IDictionary<string, object> htmlAttributes) where TActionResult : ActionResult {
            return T4Extensions.BeginRouteForm(htmlHelper, routeName, taskResult.Result, method, htmlAttributes);
        }

        public static void RenderAction<TActionResult>(this HtmlHelper htmlHelper, Task<TActionResult> taskResult) where TActionResult : ActionResult {
            T4Extensions.RenderAction(htmlHelper, taskResult.Result);
        }

        public static MvcHtmlString Action<TActionResult>(this HtmlHelper htmlHelper, Task<TActionResult> taskResult) where TActionResult : ActionResult {
            return T4Extensions.Action(htmlHelper, taskResult.Result);
        }

        public static string Action<TActionResult>(this UrlHelper urlHelper, Task<TActionResult> taskResult) where TActionResult : ActionResult {
            return T4Extensions.Action(urlHelper, taskResult.Result, (string)null, (string)null);
        }

        public static string Action<TActionResult>(this UrlHelper urlHelper, Task<TActionResult> taskResult, string protocol = null, string hostName = null) where TActionResult : ActionResult {
            return T4Extensions.Action(urlHelper, taskResult.Result, protocol, hostName);
        }

        public static string ActionAbsolute<TActionResult>(this UrlHelper urlHelper, Task<TActionResult> taskResult) where TActionResult : ActionResult {
            return T4Extensions.ActionAbsolute(urlHelper, taskResult.Result);
        }

        public static string RouteUrl<TActionResult>(this UrlHelper urlHelper, Task<TActionResult> taskResult) where TActionResult : ActionResult {
            return T4Extensions.RouteUrl(urlHelper, (string)null, taskResult.Result, (string)null, (string)null);
        }

        public static string RouteUrl<TActionResult>(this UrlHelper urlHelper, string routeName, Task<TActionResult> taskResult) where TActionResult : ActionResult {
            return T4Extensions.RouteUrl(urlHelper, routeName, taskResult.Result, (string)null, (string)null);
        }

        public static string RouteUrl<TActionResult>(this UrlHelper urlHelper, string routeName, Task<TActionResult> taskResult, string protocol) where TActionResult : ActionResult {
            return T4Extensions.RouteUrl(urlHelper, routeName, taskResult.Result, protocol, (string)null);
        }

        public static string RouteUrl<TActionResult>(this UrlHelper urlHelper, string routeName, Task<TActionResult> taskResult, string protocol, string hostName) where TActionResult : ActionResult {
            return T4Extensions.RouteUrl(urlHelper, routeName, taskResult.Result, protocol, hostName);
        }

        public static MvcHtmlString ActionLink<TActionResult>(this AjaxHelper ajaxHelper, string linkText, Task<TActionResult> taskResult, AjaxOptions ajaxOptions) where TActionResult : ActionResult {
            return T4Extensions.ActionLink(ajaxHelper, linkText, taskResult.Result, ajaxOptions);
        }

        public static MvcHtmlString ActionLink<TActionResult>(this AjaxHelper ajaxHelper, string linkText, Task<TActionResult> taskResult, AjaxOptions ajaxOptions, object htmlAttributes) where TActionResult : ActionResult {
            return T4Extensions.ActionLink(ajaxHelper, linkText, taskResult.Result, ajaxOptions, htmlAttributes);
        }

        public static MvcHtmlString ActionLink<TActionResult>(this AjaxHelper ajaxHelper, string linkText, Task<TActionResult> taskResult, AjaxOptions ajaxOptions, IDictionary<string, object> htmlAttributes) where TActionResult : ActionResult {
            return T4Extensions.ActionLink(ajaxHelper, linkText, taskResult.Result, ajaxOptions, htmlAttributes);
        }

        public static MvcHtmlString RouteLink<TActionResult>(this AjaxHelper ajaxHelper, string linkText, string routeName, Task<TActionResult> taskResult, AjaxOptions ajaxOptions) where TActionResult : ActionResult {
            return T4Extensions.RouteLink(ajaxHelper, linkText, routeName, taskResult.Result, ajaxOptions, (IDictionary<string, object>)null);
        }

        public static MvcHtmlString RouteLink<TActionResult>(this AjaxHelper ajaxHelper, string linkText, string routeName, Task<TActionResult> taskResult, AjaxOptions ajaxOptions, object htmlAttributes) where TActionResult : ActionResult {
            return T4Extensions.RouteLink(ajaxHelper, linkText, routeName, taskResult.Result, ajaxOptions, (IDictionary<string, object>)HtmlHelper.AnonymousObjectToHtmlAttributes(htmlAttributes));
        }

        public static MvcHtmlString RouteLink<TActionResult>(this AjaxHelper ajaxHelper, string linkText, string routeName, Task<TActionResult> taskResult, AjaxOptions ajaxOptions, IDictionary<string, object> htmlAttributes) where TActionResult : ActionResult {
            return T4Extensions.RouteLink(ajaxHelper, linkText, routeName, taskResult.Result, ajaxOptions, htmlAttributes);
        }

        public static MvcForm BeginRouteForm<TActionResult>(this AjaxHelper ajaxHelper, string routeName, Task<TActionResult> taskResult, AjaxOptions ajaxOptions) where TActionResult : ActionResult {
            return T4Extensions.BeginRouteForm(ajaxHelper, routeName, taskResult.Result, ajaxOptions, (IDictionary<string, object>)null);
        }

        public static MvcForm BeginRouteForm<TActionResult>(this AjaxHelper ajaxHelper, string routeName, Task<TActionResult> taskResult, AjaxOptions ajaxOptions, object htmlAttributes) where TActionResult : ActionResult {
            return T4Extensions.BeginRouteForm(ajaxHelper, routeName, taskResult.Result, ajaxOptions, (IDictionary<string, object>)HtmlHelper.AnonymousObjectToHtmlAttributes(htmlAttributes));
        }

        public static MvcForm BeginRouteForm<TActionResult>(this AjaxHelper ajaxHelper, string routeName, Task<TActionResult> taskResult, AjaxOptions ajaxOptions, IDictionary<string, object> htmlAttributes) where TActionResult : ActionResult {
            return T4Extensions.BeginRouteForm(ajaxHelper, routeName, taskResult.Result, ajaxOptions, htmlAttributes);
        }

        public static Route MapRoute<TActionResult>(this RouteCollection routes, string name, string url, Task<TActionResult> taskResult) where TActionResult : ActionResult {
            return T4Extensions.MapRoute(routes, name, url, taskResult.Result, (string[])null);
        }

        public static Route MapRoute<TActionResult>(this RouteCollection routes, string name, string url, Task<TActionResult> taskResult, object defaults) where TActionResult : ActionResult {
            return T4Extensions.MapRoute(routes, name, url, taskResult.Result, defaults, (object)null, (string[])null);
        }

        public static Route MapRoute<TActionResult>(this RouteCollection routes, string name, string url, Task<TActionResult> taskResult, string[] namespaces) where TActionResult : ActionResult {
            return T4Extensions.MapRoute(routes, name, url, taskResult.Result, (object)null, namespaces);
        }

        public static Route MapRoute<TActionResult>(this RouteCollection routes, string name, string url, Task<TActionResult> taskResult, object defaults, object constraints) where TActionResult : ActionResult {
            return T4Extensions.MapRoute(routes, name, url, taskResult.Result, defaults, constraints, (string[])null);
        }

        public static Route MapRoute<TActionResult>(this RouteCollection routes, string name, string url, Task<TActionResult> taskResult, object defaults, string[] namespaces) where TActionResult : ActionResult {
            return T4Extensions.MapRoute(routes, name, url, taskResult.Result, defaults, (object)null, namespaces);
        }

        public static Route MapRoute<TActionResult>(this RouteCollection routes, string name, string url, Task<TActionResult> taskResult, object defaults, object constraints, string[] namespaces) where TActionResult : ActionResult {
            return T4Extensions.MapRoute(routes, name, url, taskResult.Result, defaults, constraints, namespaces);
        }

        public static Route MapRouteArea<TActionResult>(this AreaRegistrationContext context, string name, string url, Task<TActionResult> taskResult) where TActionResult : ActionResult {
            return T4Extensions.MapRouteArea(context, name, url, taskResult.Result, (string[])null);
        }

        public static Route MapRouteArea<TActionResult>(this AreaRegistrationContext context, string name, string url, Task<TActionResult> taskResult, object defaults) where TActionResult : ActionResult {
            return T4Extensions.MapRouteArea(context, name, url, taskResult.Result, defaults, (object)null, (string[])null);
        }

        public static Route MapRouteArea<TActionResult>(this AreaRegistrationContext context, string name, string url, Task<TActionResult> taskResult, string[] namespaces) where TActionResult : ActionResult {
            return T4Extensions.MapRouteArea(context, name, url, taskResult.Result, (object)null, namespaces);
        }

        public static Route MapRouteArea<TActionResult>(this AreaRegistrationContext context, string name, string url, Task<TActionResult> taskResult, object defaults, object constraints) where TActionResult : ActionResult {
            return T4Extensions.MapRouteArea(context, name, url, taskResult.Result, defaults, constraints, (string[])null);
        }

        public static Route MapRouteArea<TActionResult>(this AreaRegistrationContext context, string name, string url, Task<TActionResult> taskResult, object defaults, string[] namespaces) where TActionResult : ActionResult {
            return T4Extensions.MapRouteArea(context, name, url, taskResult.Result, defaults, (object)null, namespaces);
        }

        public static Route MapRouteArea<TActionResult>(this AreaRegistrationContext context, string name, string url, Task<TActionResult> taskResult, object defaults, object constraints, string[] namespaces) where TActionResult : ActionResult {
            return T4Extensions.MapRouteArea(context, name, url, taskResult.Result, defaults, constraints, namespaces);
        }
    }

}
