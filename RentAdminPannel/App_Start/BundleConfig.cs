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
            //User CSS Design Starts here -HARLEEN KAUR
            bundles.Add(new StyleBundle("~/Content/User_css").Include(
                     "~/Content/User/assets/css/normalize.css",
                     "~/Content/User/assets/css/font-awesome.min.css",
                     "~/Content/User/assets/css/rating.css",
                     "~/Content/User/assets/css/fontello.css",
                     "~/Content/User/assets/fonts/icon-7-stroke/css/pe-icon-7-stroke.css",
                     "~/Content/User/assets/fonts/icon-7-stroke/css/helper.css",
                     "~/Content/User/assets/css/animate.css",
                     "~/Content/User/assets/css/bootstrap-select.min.css",
                     "~/Content/User/bootstrap/css/bootstrap.min.css",
                     "~/Content/User/assets/css/icheck.min_all.css",
                     "~/Content/User/assets/css/price-range.css",
                     "~/Content/User/assets/css/owl.carousel.css",
                     "~/Content/User/assets/css/owl.theme.css",
                     "~/Content/User/assets/css/owl.transitions.css",
                     "~/Content/User/assets/css/style.css",
                     "~/Content/User/assets/css/responsive.css",
                     "~/Content/User/assets/css/wizard.css",
                      "~/Content/User/assets/css/lightslider.min.css"
                   ));
            //User Design  Ends
            //--------------------------------------------------------------------
            //User Scripts starts here
            bundles.Add(new ScriptBundle("~/bundles/User_js").Include(
                     "~/Content/User/assets/js/modernizr-2.6.2.min.js",
                     "~/Content/User/assets/js/jquery-1.10.2.min.js",
                     "~/Content/User/bootstrap/js/bootstrap.min.js",
                     "~/Content/User/assets/js/bootstrap-select.min.js",
                     "~/Content/User/assets/js/bootstrap-hover-dropdown.js",
                      "~/Content/User/assets/js/easypiechart.min.js",
                     "~/Content/User/assets/js/jquery.easypiechart.min.js",
                     "~/Content/User/assets/js/owl.carousel.min.js",
                     "~/Content/User/assets/js/wow.js",
                      "~/Content/User/assets/js/icheck.min.js",
                       "~/Content/User/assets/js/price-range.js",
                        "~/Content/User/assets/js/main.js",
                        "~/Content/User/assets/js/jquery.bootstrap.wizard.js",
                        "~/Content/User/assets/js/jquery.validate.min.js",
                        "~/Content/User/assets/js/wizard.js",
                         "~/Content/User/assets/js/jquery.js",
                          "~/Content/User/assets/js/state.js",
                          "~/Content/User/assets/js/lightslider.min.js"

                       ));
            //User  srcipts Ends

        }
    }
}
