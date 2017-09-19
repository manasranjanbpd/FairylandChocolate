using System.Web.Mvc;
using System.Web.Routing;

namespace FairylandChocolate
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

			routes.MapRoute(
				name: "productCategory",
				url: "Chocolate/{id}",
				defaults: new { controller = "Chocolates", action = "Category", id = UrlParameter.Optional }
			);

			routes.MapRoute(
				name: "productDetails",
				url: "Chocolates/{id}",
				defaults: new { controller = "Chocolates", action = "Index", id = UrlParameter.Optional }
			);

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}
