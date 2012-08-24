using System.Web;
using System.Web.Optimization;

namespace AngularJS_NetPonto
{
    public class BundleConfig
    {
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery-1.8*"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryui").Include(
                        "~/Scripts/jquery-ui*"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/jquery.unobtrusive*",
                        "~/Scripts/jquery.validate*"));

            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            bundles.Add(new ScriptBundle("~/bundles/angular")
                        .Include("~/Scripts/AngularJS/angular*")
                        .Include("~/Scripts/underscore*"));

            bundles.Add(new ScriptBundle("~/bundles/netponto-app")
                        .Include("~/Content/app/js/app.js")
                        .Include("~/Content/app/js/controllers.js")
                        .Include("~/Content/app/js/filters.js")
                        .Include("~/Content/app/js/resources.js"));

            bundles.Add(new ScriptBundle("~/bundles/twitterbootstrap").Include(
                        "~/Scripts/TwitterBootstrap/bootstrap.js"));

            bundles.Add(new StyleBundle("~/Content/css")
                        .Include("~/Content/css/Site.css")
                        .Include("~/Content/css/twitter.bootstrap.css"));

            bundles.Add(new StyleBundle("~/Content/themes/base/css").Include(
                        "~/Content/themes/base/jquery.ui.core.css",
                        "~/Content/themes/base/jquery.ui.resizable.css",
                        "~/Content/themes/base/jquery.ui.selectable.css",
                        "~/Content/themes/base/jquery.ui.accordion.css",
                        "~/Content/themes/base/jquery.ui.autocomplete.css",
                        "~/Content/themes/base/jquery.ui.button.css",
                        "~/Content/themes/base/jquery.ui.dialog.css",
                        "~/Content/themes/base/jquery.ui.slider.css",
                        "~/Content/themes/base/jquery.ui.tabs.css",
                        "~/Content/themes/base/jquery.ui.datepicker.css",
                        "~/Content/themes/base/jquery.ui.progressbar.css",
                        "~/Content/themes/base/jquery.ui.theme.css"));
            
        }
    }
}