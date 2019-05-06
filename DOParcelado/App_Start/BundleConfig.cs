using System.Web;
using System.Web.Optimization;

namespace DOParcelado
{
    public class BundleConfig
    {
        // For more information on bundling, visit https://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery-{version}.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/jquery.validate*"));

            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at https://modernizr.com to pick only the tests you need.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                      "~/Scripts/bootstrap.js"));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/bootstrap.css",
                      "~/Content/site.css"));

            bundles.Add(new StyleBundle("~/TemplateItau/css").Include(
                "~/Assets/plugins/bootstrap/css/bootstrap.min.css",
                "~/Assets/plugins/wizard/steps.css",
                "~/Assets/plugins/dropify/dist/css/dropify.min.css",
                "~/Assets/plugins/bootstrap-material-datetimepicker/css/bootstrap-material-datetimepicker.css",
                "~/Assets/plugins/clockpicker/jquery-clockpicker.min.css",
                "~/Assets/plugins/jquery-asColorPicker-master/css/asColorPicker.css",
                "~/Assets/plugins/bootstrap-datepicker/bootstrap-datepicker.min.css",
                "~/Assets/plugins/timepicker/bootstrap-timepicker.min.css",
                "~/Assets/plugins/bootstrap-daterangepicker/daterangepicker.css",
                "~/Assets/plugins/dropzone-master/dropzone.css",
                "~/Assets/plugins/nestable/nestable.css",
                "~/Assets/plugins/sweetalert/sweetalert.css",
                "~/Assets/plugins/toast-master/css/jquery.toast.css",
                "~/Assets/css/style.css",
                "~/Assets/css/colors/blue-dark.css"
                ));
        }
    }
}
