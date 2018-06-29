using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace ASP_project
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );
            routes.MapRoute(
            name: "Produits",
            url: "{controller}/{action}/{id}",
            defaults: new { controller = "Produits", action = "Liste", id = UrlParameter.Optional }
        );
            routes.MapRoute(
            name: "Details",
            url: "{controller}/{action}/{id}",
            defaults: new { controller = "Produits", action = "Details", id = UrlParameter.Optional }
            );
            routes.MapRoute(
            name: "Adding",
            url: "{controller}/{action}/{id}",
            defaults: new { controller = "Produits", action = "Adding", id = UrlParameter.Optional }
            );
            routes.MapRoute(
            name: "AddProduit",
            url: "{controller}/{action}",
            defaults: new { controller = "Produits", action = "AddProduits", id = UrlParameter.Optional }
            );
        }
    }
}
