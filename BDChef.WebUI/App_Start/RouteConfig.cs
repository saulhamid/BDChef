using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace BDChef.WebUI
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            //routes.MapRoute(
            //    name: "Default",
            //    url: "{controller}/{action}/{id}",
            //    defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            //);

           
            
            routes.MapRoute(
               name: "Home",
               url: "Max/home",
               defaults: new { controller = "Max", action = "home", id = UrlParameter.Optional }
           );
            routes.MapRoute(
              name: "Category",
              url: "Max/Category",
              defaults: new { controller = "Max", action = "Category", id = UrlParameter.Optional }
          );
            routes.MapRoute(
              name: "Vendor",
              url: "Max/Vendor",
              defaults: new { controller = "Max", action = "Vendor", id = UrlParameter.Optional }
          );
            routes.MapRoute(
             name: "Customer",
             url: "Max/Customer",
             defaults: new { controller = "Max", action = "Customer", id = UrlParameter.Optional }
         );
            routes.MapRoute(
                 "default_route",
                   "{*.}",
                   defaults: new { controller = "Max", action = "Index" });
        }
    }
}
