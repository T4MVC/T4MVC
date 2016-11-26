using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Mvc.Html;

namespace T4MVCAutoNamedRouteApp.T4MVC
{
	public static class RouteExtensions
	{
		public static string ComposeAutoRouteName( string areaName, string controllerName, string actionName )
		{
			if( controllerName == null )
				throw new ArgumentNullException( "Controller name cannot be null" );
			if( actionName == null )
				throw new ArgumentNullException( "Action name cannot be null" );

			if( string.IsNullOrWhiteSpace( areaName ) )
				areaName = "__AUTONAMEDROUTE_DEFAULT__";

			return string.Join( "_", areaName, controllerName, actionName ).ToLowerInvariant();
		}

		public static MvcHtmlString AutoNamedActionLink( this HtmlHelper htmlHelper, string linkText, ActionResult result )
		{
			var t4mvcRes = result.GetT4MVCResult();
			string actionName = t4mvcRes.Action;
			string ctrlName = t4mvcRes.Controller;
			// get area from route values
			object areaName = "";
			t4mvcRes.RouteValueDictionary.TryGetValue( "area", out areaName );
			t4mvcRes.RouteValueDictionary.Remove( "area" );
			// compose route name
			string routeName = ComposeAutoRouteName( areaName as string, ctrlName, actionName );
			return htmlHelper.RouteLink( linkText, routeName, t4mvcRes.RouteValueDictionary );
		}
	}
}