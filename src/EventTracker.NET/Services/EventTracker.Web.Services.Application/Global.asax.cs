using System.Web;
using System.Web.Mvc;
using System.Web.Routing;
using EventTracker.Web.Services.Application.App_Start;

namespace EventTracker.Web.Services.Application
{
	// Note: For instructions on enabling IIS6 or IIS7 classic mode, 
	// visit http://go.microsoft.com/?LinkId=9394801
	public class MvcApplication : HttpApplication
	{
		protected void Application_Start()
		{
			AreaRegistration.RegisterAllAreas();

			// ServiceStack conflicts with WebApi, so do not register it
			//WebApiConfig.Register(GlobalConfiguration.Configuration);

			FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
			RouteConfig.RegisterRoutes(RouteTable.Routes);
		}
	}
}