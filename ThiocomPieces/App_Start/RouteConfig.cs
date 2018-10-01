using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace ThiocomPieces
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
               name: "Cliche",
               url: "cliche/{id}",
               defaults: new { controller = "Produits", action = "Image" }
           );

            routes.MapRoute(
                    name: "Produits",
                    url:"produit/{nom}/produitId",
                    defaults: new {controller="Produits", action="Produit"}
                );

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}
