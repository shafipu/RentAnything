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
                        "~/Scripts/jquery-{version}.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/jquery.validate*"));

            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at http://modernizr.com to pick only the tests you need.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                      "~/Scripts/bootstrap.js",
                      "~/Scripts/respond.js"));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/bootstrap.css",
                      "~/Content/site.css"));

            //Admin Dashboard srcipts Starts
            //--------------------------------------------------------------------
            bundles.Add(new ScriptBundle("~/bundles/Admin_js").Include(
                      "~/Content/Admin/assets/js/jquery-3.2.1.min.js",
                      "~/Content/Admin/assets/js/bootstrap.min.js",
                      "~/Content/Admin/assets/js/material.min.js",
                      "~/Content/Admin/assets/js/chartist.min.js",
                      "~/Content/Admin/assets/js/arrive.min.js",
                      "~/Content/Admin/assets/js/perfect-scrollbar.jquery.min.js",
                      "~/Content/Admin/assets/js/bootstrap-notify.js",
                      "~/Content/Admin/assets/js/demo.js",
                      "~/Content/Admin/assets/js/material-dashboard.js"));
            //Admin Dashboard srcipts Ends
            //--------------------------------------------------------------------

            //Admin Dashboard Styles Starts
            //--------------------------------------------------------------------
            bundles.Add(new StyleBundle("~/Content/Admin_css").Include(
                      "~/Content/Admin/assets/css/bootstrap.min.css",
                      "~/Content/Admin/assets/css/material-dashboard.css"));
            //Admin Dashboard Styles Ends
            //--------------------------------------------------------------------


        }
    }
}
