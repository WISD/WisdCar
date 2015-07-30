using System.Web;
using System.Web.Optimization;

namespace Zeta.WisdCar.Online
{
    public class BundleConfig
    {
        // For more information on bundling, visit http://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/core/js").Include(
                        "~/assets/plugins/jquery-1.10.2.min.js",
                        "~/assets/plugins/jquery-migrate-1.2.1.min.js",
                        "~/assets/plugins/jquery-ui/jquery-ui.min.js",    //IMPORTANT! Load jquery-ui.min.js before bootstrap.min.js to fix bootstrap tooltip conflict with jquery ui tooltip
                        "~/assets/plugins/bootstrap/js/bootstrap.min.js",
                        "~/assets/plugins/bootstrap-hover-dropdown/bootstrap-hover-dropdown.min.js",
                        "~/assets/plugins/jquery-slimscroll/jquery.slimscroll.min.js",
                        "~/assets/plugins/jquery.blockui.min.js",
                        "~/assets/plugins/jquery.cokie.min.js",
                        "~/assets/plugins/uniform/jquery.uniform.min.js"));

            bundles.Add(new StyleBundle("~/global/css").Include(
                "~/assets/plugins/font-awesome/css/font-awesome.min.css",
                "~/assets/plugins/bootstrap/css/bootstrap.min.css",
                "~/assets/plugins/uniform/css/uniform.default.css"));

            bundles.Add(new StyleBundle("~/theme/css").Include(
                "~/assets/css/style-metronic.css",
                "~/assets/css/style.css",
                "~/assets/css/style-responsive.css",
                "~/assets/css/plugins.css",
                "~/assets/css/themes/default.css",
                "~/assets/css/custom.css"));
        }
    }
}
