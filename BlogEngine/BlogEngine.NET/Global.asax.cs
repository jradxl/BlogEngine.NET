using System;
using System.Web;
using System.Web.Routing;
using System.Web.Mvc;
using BlogEngine.NET.App_Start;
using BlogEngine.Core;

namespace BlogEngine.NET
{
	public class Global : System.Web.HttpApplication
	{
		protected void Application_Start(object sender, EventArgs e)
		{
			RegisterRoutes(RouteTable.Routes);
		}

		protected void Application_BeginRequest(object sender, EventArgs e)
		{
			var app = (HttpApplication) sender;
			BlogEngineConfig.Initialize(app.Context);
		}

		void Application_PreRequestHandlerExecute(object sender, EventArgs e)
		{
			BlogEngineConfig.SetCulture(sender, e);
		}

		void RegisterRoutes(RouteCollection routes)
		{
			//JSR Available with Net 4.5.2
			//routes.LowercaseUrls = true;

			routes.MapPageRoute("john1", "john1", "~/john1.aspx");
			//routes.IgnoreRoute("{resource}.axd/{*pathInfo}");
			//routes.MapRoute("Default", "{controller}/{action}/{id}", new { controller = "Admin", action = "Index", id = "" });
		}

		protected void Session_Start(object sender, EventArgs e)
		{
		}

		protected void Application_AuthenticateRequest(object sender, EventArgs e)
		{
		}

		protected void Application_Error(object sender, EventArgs e)
		{
			Exception ex = Server.GetLastError();

			if ( ex != null)
				Console.WriteLine("Exception Message: {0}", ex.Message);

			if (ex is HttpException)
			{
				if (((HttpException)(ex)).GetHttpCode() == 404)
				{
					//Response.RedirectToRoute("john1");
					//Response.Redirect(Utils.AbsoluteWebRoot + "john1", true);
                }
			}
			//Response.RedirectToRoute("john1");
			//Response.Redirect(Utils.AbsoluteWebRoot + "john1", true);
		}

		protected void Session_End(object sender, EventArgs e)
		{
		}

		protected void Application_End(object sender, EventArgs e)
		{
		}
	}
}
