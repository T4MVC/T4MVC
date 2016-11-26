using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc.Routing;

namespace T4MVCAutoNamedRouteApp.T4MVC
{
	[AttributeUsage( AttributeTargets.Method | AttributeTargets.Class, Inherited = false, AllowMultiple = true )]
	public class AutoNamedRouteAttribute : Attribute, IDirectRouteFactory
	{
		public string Template
		{
			get;
			set;
		}

		public int Order
		{
			get;
			set;
		}

		public AutoNamedRouteAttribute()
		{

		}

		public AutoNamedRouteAttribute( string template )
		{
			Template = template;
		}

		private string getAreaName( System.Web.Mvc.ControllerDescriptor controllerDescriptor )
		{
			System.Web.Mvc.RouteAreaAttribute areaAttribute =
			   controllerDescriptor.GetCustomAttributes( typeof( System.Web.Mvc.RouteAreaAttribute ), inherit: true )
								   .Cast<System.Web.Mvc.RouteAreaAttribute>()
								   .FirstOrDefault();

			if( areaAttribute == null )
				return null;

			if( areaAttribute.AreaName != null )
				return areaAttribute.AreaName;

			if( controllerDescriptor.ControllerType.Namespace != null )
				return controllerDescriptor.ControllerType.Namespace.Split( '.' ).Last();

			return null;
		}

		public RouteEntry CreateRoute( DirectRouteFactoryContext context )
		{
			if( !context.TargetIsAction )
				throw new InvalidOperationException( "AutoNamedRouteAttribute should be only used on actions" );
			if( !context.Actions.Any() )
				throw new InvalidOperationException( "Actions should be empty" );

			IDirectRouteBuilder builder = context.CreateBuilder( Template );
			// generate name:
			// get the first action descriptor from our list because we only need to get its name
			var actionDescriptor = context.Actions.First();
			var controllerDescriptor = actionDescriptor.ControllerDescriptor;
			var actionName = actionDescriptor.ActionName;
			var controllerName = controllerDescriptor.ControllerName;
			// get area also
			var areaName = getAreaName( controllerDescriptor );
			// compose a name
			builder.Name = RouteExtensions.ComposeAutoRouteName( areaName, controllerName, actionName );
			builder.Order = Order;
			return builder.Build();
		}
	}
}