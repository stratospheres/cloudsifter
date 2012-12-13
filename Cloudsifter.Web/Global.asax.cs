using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Routing;
using System.Web.Security;
using System.Web.SessionState;

namespace Cloudsifter.Web
{
    public class Global : System.Web.HttpApplication
    {
        void RegisterRoutes(RouteCollection Routes)
        {
			Routes.MapPageRoute(
                "Subscribe-Browse",
                "subscribe",
                "~/Subscribe.aspx"
                );
            Routes.MapPageRoute(
                "Submit-Browse",
                "submit",
                "~/Submit.aspx"
                );
            Routes.MapPageRoute(
                "PastIssues-Browse",
                "past",
                "~/PastIssues.aspx"
                );
            Routes.MapPageRoute(
                "PastIssue-Browse",
                "past/{Month}/{Day}/{Year}",
                "~/PastIssue.aspx"
                );
			Routes.MapPageRoute(
				"Link-Browse",
				"link/{ID}",
				"~/Link.aspx"
				);
			Routes.MapPageRoute(
                "Latest-Browse",
                "latest",
                "~/Latest.aspx"
                );
            Routes.MapPageRoute(
                "SiteMapXML-Browse",
                "sitemap.xml",
                "~/SiteMap.aspx"
                );

			// wildcard goes to home page
			Routes.MapPageRoute("defaultRoute", "{*value}", "~/Default.aspx");
			Routes.RouteExistingFiles = false;
		}

        protected void Application_Start(object sender, EventArgs e)
        {
            RegisterRoutes(RouteTable.Routes);
        }

        protected void Session_Start(object sender, EventArgs e)
        {

        }

        protected void Application_BeginRequest(object sender, EventArgs e)
        {

        }

        protected void Application_AuthenticateRequest(object sender, EventArgs e)
        {

        }

        protected void Application_Error(object sender, EventArgs e)
        {

        }

        protected void Session_End(object sender, EventArgs e)
        {

        }

        protected void Application_End(object sender, EventArgs e)
        {

        }
    }
}