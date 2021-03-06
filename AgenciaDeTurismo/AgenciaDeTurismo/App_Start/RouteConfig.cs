﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace AgenciaDeTurismo
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Inicio", id = UrlParameter.Optional }
            );

            /*20170905 - Rama Admin*/
            routes.MapRoute(
                name: "AdminDelete",
                url: "{controller}/{action}/{subaction}/{id}"
                
            );

            routes.MapRoute(
                name: "AdminGeneral",
                url: "{controller}/{action}/{subaction}"

            );
        }
    }
}
