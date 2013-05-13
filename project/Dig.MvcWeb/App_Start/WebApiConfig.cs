using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;


namespace Dig.MvcWeb
{
	public static class WebApiConfig
	{
		public static void Register(HttpConfiguration config)
		{
			config.Routes.MapHttpRoute(
				name: "DefaultApi",
				routeTemplate: "api/{controller}/{id}",
				defaults: new { id = RouteParameter.Optional }
			);

			//*** je - allow circular reference in json web api output. Allows for more complex objects.
			var json = config.Formatters.JsonFormatter;
			json.SerializerSettings.PreserveReferencesHandling = Newtonsoft.Json.PreserveReferencesHandling.Objects;
			json.SerializerSettings.NullValueHandling = Newtonsoft.Json.NullValueHandling.Include;



			//*** je - remove xml from web api format
			config.Formatters.Remove(config.Formatters.XmlFormatter);
		}
	}
}
