﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace SampleApp
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                name: "Home",
                url: "Home/page",
                defaults: new { controller = "Home", action = "GotoHome", id = UrlParameter.Optional }
            );
            routes.MapRoute(
                name: "Home1",
                url: "",
                defaults: new { controller = "Home", action = "GotoHome", id = UrlParameter.Optional }
            );
            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "GotoHome", id = UrlParameter.Optional }
            );
        }
    }
}
