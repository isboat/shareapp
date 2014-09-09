using System.Web;
using System.Web.Optimization;

namespace Cms.Client.Web
{
    public class BundleConfig
    {
        // For more information on Bundling, visit http://go.microsoft.com/fwlink/?LinkId=254725
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(
                new ScriptBundle("~/bundles/libs").Include(
                    "~/Scripts/Libs/jquery.js",
                    "~/Scripts/Libs/angular.js",
                    "~/Scripts/Libs/angular-route.js",
                    "~/Scripts/Libs/angular-sanitize.js"));

            bundles.Add(
                new ScriptBundle("~/bundles/app").Include(
                    "~/Scripts/App/app.js", 
                    "~/Scripts/App//Ctrs/homeController.js", 
                    "~/Scripts/App/Ctrs/searchController.js"));

            bundles.Add(new StyleBundle("~/Content/css").Include("~/Content/Site.css"));
        }
    }
}