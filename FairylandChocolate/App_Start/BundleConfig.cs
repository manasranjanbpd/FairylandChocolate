using System;
using System.Web.Optimization;

namespace FairylandChocolate.App_Start
{
    public class BundleConfig
    {
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include("~/Scripts/jquery-{version}.min.js"));

            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at http://modernizr.com to pick only the tests you need.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include("~/Scripts/modernizr-*"));
            bundles.Add(new ScriptBundle("~/bundles/Materialize").Include("~/Scripts/materialize.min.js", "~/Scripts/respond.min.js"));
            bundles.Add(new StyleBundle("~/Content/materializeCss").Include("~/Content/materialize.min.css", "~/Content/Material-Icons.css"));
            bundles.Add(new StyleBundle("~/Content/Admin").Include("~/Content/siteadmin.css"));
            bundles.Add(new StyleBundle("~/bundles/AdminJs").Include("~/Scripts/siteadmin.js"));
            bundles.Add(new StyleBundle("~/bundles/Angular").Include("~/Scripts/angular.min.js","~/Scripts/angular-route.min.js"
                , "~/Scripts/angular-materialize.min.js",
                "~/Scripts/app/AdminApp.js", "~/Scripts/controller/productCtrl.js",
                "~/Scripts/service/productService.js"));
            // Set EnableOptimizations to false for debugging. For more information,
            // visit http://go.microsoft.com/fwlink/?LinkId=301862
            BundleTable.EnableOptimizations = true;
        }
    }
}