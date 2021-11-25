using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

using Kentico.Web.Mvc;

namespace DotStark_LLP
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            // Maps routes to Kentico HTTP handlers and features enabled in ApplicationConfig.cs
            // Always map the Kentico routes before adding other routes. Issues may occur if Kentico URLs are matched by a general route, for example images might not be displayed on pages
            routes.Kentico().MapRoutes();

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );
            var route = routes.MapRoute(
                name: "Kentico",
                url: "{culture}/Kenticos/{guid}/{pageAlias}",
                defaults: new { controller = "Kentico", action = "Index", id = UrlParameter.Optional }
                //constraints: new { culture = new SiteCultureConstraint(), guid = new GuidRouteConstraint() }
            );
        }
    }
}
