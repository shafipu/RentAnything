using System.Web;
using System.Web.Optimization;

namespace RentAdminPannel
{
    public class BundleConfig
    {
        // For more information on bundling, visit http://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery-{version}.js",
                        "~/assets/js/jquery-{version}.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/jquery.validate*"));

            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at http://modernizr.com to pick only the tests you need.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                      "~/Scripts/bootstrap.js",
                      "~/Scripts/respond.js"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap_material").Include(
                      "~/assets/js/bootstrap.min.js",
                      "~/assets/jsbootstrap-notify.js",
                      "~/assets/js/arrive.min.js",
                      "~/assets/js/chartist.min.js",
                      "~/assets/js/demo.js",
                      "~/assets/js/material-dashboard.js",
                      "~/assets/js/material.min.js",
                      "~/assets/js/perfect-scrollbar.jquery.min.js"));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/bootstrap.css",
                      "~/assets/css/material-dashboard.css",
                      "~/assets/css/demo.css",
                      "~/Content/site.css"));
        }
    }
}
