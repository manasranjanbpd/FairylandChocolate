using System.Web;
using System.Web.Mvc;
using System.Web.Routing;
using System.Web.Http;
using FairylandChocolate.App_Start;
using System.Web.Optimization;

namespace FairylandChocolate
{
    public class Global : HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
        }
    }
}
