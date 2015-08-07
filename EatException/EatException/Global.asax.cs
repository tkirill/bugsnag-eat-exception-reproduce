using System;
using System.IO;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;
using Bugsnag.Clients;

namespace EatException
{
    public class Global : HttpApplication
    {
        protected void Application_Start(object sender, EventArgs e)
        {
            RouteTable.Routes.MapMvcAttributeRoutes();
            GlobalFilters.Filters.Add(WebMVCClient.ErrorHandler());  // comment out to get original exception
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
            File.AppendAllText(@"C:\logs\eat-exceptions.log", "\n\n=============\n\n" + Server.GetLastError());
        }

        protected void Session_End(object sender, EventArgs e)
        {
        }

        protected void Application_End(object sender, EventArgs e)
        {
        }
    }
}