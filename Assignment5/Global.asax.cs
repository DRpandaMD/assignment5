﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Optimization;
using System.Web.Routing;
using System.Web.Security;
using System.Web.SessionState;

//WRITTEN BY NATHAN HILL

namespace Assignment5
{
    public class Global : HttpApplication
    {
        void Application_Start(object sender, EventArgs e)
        {
            // Code that runs on application startup
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);

            if (!File.Exists(Server.MapPath("~/App_Data/Member.xml")))
            {
                File.WriteAllText(Server.MapPath("~/App_Data/Member.xml"), "<Members></Members>");
            }
        }
    }
}