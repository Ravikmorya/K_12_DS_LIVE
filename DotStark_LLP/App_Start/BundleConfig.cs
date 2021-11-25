using System.Web;
using System.Web.Optimization;

namespace DotStark_LLP
{
    public class BundleConfig
    {
        // For more information on bundling, visit https://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            // Custom JavaScript files from the ~/Scripts/ directory can be included as well
            bundles.Add(new ScriptBundle("~/bundles/scripts").Include(
                        "~/Scripts/site.js"));
            bundles.UseCdn = true;

            RegisterJqueryBundle(bundles);
            RegisterJqueryUnobtrusiveAjaxBundle(bundles);
            RegisterJqueryValidationBundle(bundles);

            // Custom CSS files from the ~/Content/ directory can be included as well
            bundles.Add(new StyleBundle("~/Content/css").Include(
                        "~/Content/site.css",
                        "~/Content/css/styles.css",
                        "~/Content/css/style.min.css",
                        "~/Content/css/bootstrap.min.css",
                        "~/Content/css/custom.css",
                        "~/Content/css/fancybox.css",
                        "~/Content/css/main.css",
                        "~/Content/css/slidefooter.css"
                        ));
        }

        private static void RegisterJqueryBundle(BundleCollection bundles)
        {
            var bundle = new ScriptBundle("~/bundles/jquery")
            {
                CdnPath = "//ajax.aspnetcdn.com/ajax/jQuery/jquery-3.3.1.min.js",
                CdnFallbackExpression = "window.jQuery"
            };

            bundle.Include("~/Scripts/jquery-{version}.js");

            bundles.Add(bundle);
        }


        private static void RegisterJqueryUnobtrusiveAjaxBundle(BundleCollection bundles)
        {
            var bundle = new ScriptBundle("~/bundles/jquery-unobtrusive-ajax")
                .Include("~/Scripts/jquery.unobtrusive-ajax.js");

            bundles.Add(bundle);
        }


        private static void RegisterJqueryValidationBundle(BundleCollection bundles)
        {
            var bundle = new ScriptBundle("~/bundles/jquery-validation")
                .Include("~/Scripts/jquery.validate*");

            bundles.Add(bundle);
        }

    }
}