﻿using System.Web.Mvc;
using System.Web.Routing;

namespace TP4.EF.MVC
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "BreakingBad", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}
