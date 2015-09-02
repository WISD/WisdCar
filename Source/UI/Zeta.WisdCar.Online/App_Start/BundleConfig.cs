using System.Web;
using System.Web.Optimization;

namespace Zeta.WisdCar.Online
{
    public class BundleConfig
    {
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
                        "~/assets/plugins/uniform/jquery.uniform.min.js",
                        "~/assets/plugins/artDialog/dist/dialog-min.js",
                        "~/assets/plugins/bootstrap-modal/js/bootstrap-modalmanager.js",
                        "~/assets/plugins/bootstrap-modal/js/bootstrap-modal.js"));

            bundles.Add(new StyleBundle("~/global/css")
                .Include("~/assets/plugins/bootstrap/css/bootstrap.min.css", new CssRewriteUrlTransform())
                .Include("~/assets/plugins/uniform/css/uniform.default.css", new CssRewriteUrlTransform())
                .Include("~/assets/plugins/artDialog/css/ui-dialog.css", new CssRewriteUrlTransform())
                .Include("~/assets/plugins/bootstrap-modal/css/bootstrap-modal-bs3patch.css", new CssRewriteUrlTransform())
                .Include("~/assets/plugins/bootstrap-modal/css/bootstrap-modal.css", new CssRewriteUrlTransform())
                .Include("~/assets/plugins/font-awesome/css/font-awesome.min.css", new CssRewriteUrlTransform()));

            bundles.Add(new StyleBundle("~/theme/css")
                .Include("~/assets/css/style-metronic.css", new CssRewriteUrlTransform())
                .Include("~/assets/css/style.css", new CssRewriteUrlTransform())
                .Include("~/assets/css/style-responsive.css", new CssRewriteUrlTransform())
                .Include("~/assets/css/plugins.css", new CssRewriteUrlTransform())
                .Include("~/assets/css/themes/default.css", new CssRewriteUrlTransform())
                .Include("~/assets/css/custom.css", new CssRewriteUrlTransform()));

        }
    }
}
