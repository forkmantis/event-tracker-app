using System.Web.Http;

namespace EventTracker.Web.Application.App_Start
{
	/// <summary>
	/// Part of Microsofts new WebAPI.
	/// </summary>
	/// <remarks>
	/// Not used with ServiceStack.NET
	/// </remarks>
	public static class WebApiConfig
	{
		public static void Register(HttpConfiguration config)
		{
			config.Routes.MapHttpRoute(
				name: "DefaultApi",
				routeTemplate: "api/{controller}/{id}",
				defaults: new { id = RouteParameter.Optional }
			);
		}
	}
}
