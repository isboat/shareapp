using System.Web;
using System.Web.Optimization;

namespace Cms.Admin.Web
{
    public class BundleConfig
    {
        // For more information on Bundling, visit http://go.microsoft.com/fwlink/?LinkId=254725
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/script").Include(
                        "~/Scripts/Lib/jquery.js", 
                        "~/Scripts/Lib/angular.js",
                        "~/Scripts/Lib/angular-route.js",
                        "~/Scripts/Lib/angular-sanitize.js"));

            bundles.Add(new ScriptBundle("~/bundles/app").Include(
                "~/Scripts/App/app.js",
                "~/Scripts/App/Ctrs/loginController.js",
                "~/Scripts/App/Ctrs/registerController.js",
                "~/Scripts/App/Ctrs/indexController.js",
                "~/Scripts/App/Ctrs/videoController.js",
                "~/Scripts/App/Ctrs/audioController.js",
                "~/Scripts/App/Ctrs/messageController.js",
                "~/Scripts/App/Services/webService.js",
                "~/Scripts/App/Services/userService.js",
                "~/Scripts/App/uiHelper.js",
                "~/Scripts/App/appSettings.js"));

            bundles.Add(new StyleBundle("~/Content/css").Include("~/Content/site.css"));
        }
    }
}