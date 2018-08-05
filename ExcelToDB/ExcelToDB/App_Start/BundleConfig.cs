using System.Web;
using System.Web.Optimization;

namespace SP.OpenData.UI.Portal
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

            bundles.Add(new ScriptBundle("~/bundles/angular").Include(
                   "~/Scripts/angular.js",
                   "~/Scripts/angular-resource.js",
                   "~/Scripts/angular-route.js",
                   "~/Scripts/angular-aria.min.js"
               ));

            bundles.Add(new ScriptBundle("~/bundles/ng-app").Include(
                   "~/ng-app/app.js",
                    "~/ng-app/navigation/navigationController.js",
                    "~/ng-app/views/home/homeController.js",
                    "~/ng-app/views/MenuItem1/menuItem1Controller.js"
              ));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                           "~/Scripts/bootstrap.js",
                           "~/Scripts/angular-ui/ui-bootstrap-tpls.js",
                           "~/Scripts/spin.js",
                           "~/Scripts/respond.js"));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/bootstrap.css",
                      "~/Content/site.css"));
        }
    }
}
