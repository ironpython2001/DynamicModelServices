﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.SessionState;
using System.Web.Http;

namespace DynamicModel.Services
{
    public class Global : System.Web.HttpApplication
    {

        protected void Application_Start(object sender, EventArgs e)
        {

            //GlobalConfiguration.Configuration.Routes.MapHttpRoute(name: "DefaultApi", routeTemplate: "api/{controller}/{id}", defaults: new { id = RouteParameter.Optional });
            //GlobalConfiguration.Configuration.Routes.MapHttpRoute(name: "DynamicModelApi", routeTemplate: "DB/Current/{controller}", defaults: new { id = RouteParameter.Optional });
            GlobalConfiguration.Configuration.Routes.MapHttpRoute(name: "DynamicModelApi", routeTemplate: "DB/{controller}/{action}", defaults: new { id = RouteParameter.Optional });
            //GlobalConfiguration.Configuration.Routes.MapHttpRoute(name: "DynamicModelApi", routeTemplate: "DB/{Current}/{action}", defaults: new { id = RouteParameter.Optional });
            

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