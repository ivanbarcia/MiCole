using System.Web;
using System.Web.Optimization;

namespace Web
{
    public class BundleConfig
    {
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/lib/jquery-{version}.min.js",
                        //"~/Scripts/lib/jquery-migrate-{version}.js",
                        "~/Scripts/lib/jquery.unobtrusive-ajax.min.js"
                        ));

            bundles.Add(new ScriptBundle("~/bundles/jqueryui").Include(
                        "~/Scripts/lib/jquery-ui-{version}.min.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/lib/jquery.validate.min.js",
                        "~/Scripts/lib/jquery.validate.unobtrusive.min.js",
                        "~/Scripts/lib/jquery.maskedinput.min.js"));

            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/lib/modernizr-*"));
            
            bundles.Add(new ScriptBundle("~/bundles/blockUI").Include(
                "~/Scripts/lib/jquery.blockUI.js"));

            bundles.Add(new ScriptBundle("~/bundles/modalform").Include(
                "~/Scripts/lib/modalform.js"));

            bundles.Add(new ScriptBundle("~/bundles/common").Include(
                "~/Scripts/lib/common.js",
                "~/Scripts/lib/menu.js",
                "~/Scripts/lib/CustomDateValidation.js"));

            bundles.Add(new ScriptBundle("~/bundles/globalize").Include(
                "~/Scripts/globalize/globalize.js",
                "~/Scripts/globalize/cultures/globalize.culture.es-AR.js"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                "~/Scripts/lib/bootstrap.min.js"));

            bundles.Add(new ScriptBundle("~/bundles/kendo").Include(
                "~/Scripts/KendoUI/kendo.all.min.js",
                "~/Scripts/KendoUI/kendo.aspnetmvc.min.js",
                "~/Scripts/KendoUI/messages/kendo.messages.es-ES.min.js",
                "~/Scripts/KendoUI/cultures/kendo.culture.es-AR.min.js"));

            bundles.Add(new ScriptBundle("~/plugins/iziToast-master/js").Include(
                "~/Content/plugins/iziToast-master/dist/js/iziToast.min.js"));

            bundles.Add(new StyleBundle("~/plugins/iziToast-master/css").Include(
                      "~/Content/plugins/iziToast-master/dist/css/iziToast.min.css"));

            bundles.Add(new StyleBundle("~/Content/kendo").Include(
                            "~/Content/KendoUI/kendo.common.min.css",
                            //"~/Content/KendoUI/kendo.material.min.css"
                            "~/Content/KendoUI/fiori/fiori.css"
                                ));

            bundles.Add(new ScriptBundle("~/bundles/signalR").Include(
                "~/Scripts/lib/jquery.signalR-{version}.min.js"));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                    "~/Content/site.css",
                    "~/Content/menu.css",
                    "~/Content/bootstrap.min.css",
                    "~/Content/animate.css",
                    "~/Content/style.css"
                      ));

            bundles.Add(new StyleBundle("~/Content/themes/base/css").Include(
                        "~/Content/themes/base/jquery-ui.min.css",
                        "~/Content/themes/base/jquery-ui.all.css"
                                ));

            bundles.Add(new ScriptBundle("~/plugins/moment").Include(
                      "~/Scripts/lib/moment.min.js"));

            //-------------------------------------------------------------------------------------//
            // CSS style (bootstrap/inspinia)
            //bundles.Add(new StyleBundle("~/Content/css2").Include(
            //          "~/Content/bootstrap.min.css",
            //          "~/Content/animate.css",
            //          "~/Content/style.css"
            //          ));

            // Font Awesome icons
            bundles.Add(new StyleBundle("~/font-awesome/css").Include(
                      "~/Content/fontawesome-all.min.css", new CssRewriteUrlTransform()));

            // Awesome bootstrap checkbox
            bundles.Add(new StyleBundle("~/plugins/awesomeCheckboxStyles").Include(
                      "~/Content/plugins/awesome-bootstrap-checkbox/awesome-bootstrap-checkbox.css"));

            // ChartJS chart
            bundles.Add(new ScriptBundle("~/plugins/chartJs").Include(
                      "~/Scripts/plugins/chartjs/Chart.min.js",
                      "~/Scripts/plugins/chartjs/utils.js",
                      "~/Scripts/plugins/chartjs/analyser.js"));

            // iCheck css styles
            bundles.Add(new StyleBundle("~/Content/plugins/iCheck/iCheckStyles").Include(
                      "~/Content/plugins/iCheck/custom.css"));

            // iCheck
            bundles.Add(new ScriptBundle("~/plugins/iCheck").Include(
                      "~/Scripts/plugins/iCheck/icheck.min.js"));

            // validate 
            bundles.Add(new ScriptBundle("~/plugins/validate").Include(
                      "~/Scripts/plugins/validate/jquery.validate.min.js"));

            // dataPicker styles
            bundles.Add(new StyleBundle("~/plugins/dataPickerStyles").Include(
                      "~/Content/plugins/datapicker/datepicker3.css"));

            // dataPicker 
            bundles.Add(new ScriptBundle("~/plugins/dataPicker").Include(
                      "~/Scripts/plugins/datapicker/bootstrap-datepicker.js"));


            // wizardSteps styles
            bundles.Add(new StyleBundle("~/plugins/wizardStepsStyles").Include(
                      "~/Content/plugins/steps/jquery.steps.css"));

            // wizardSteps 
            bundles.Add(new ScriptBundle("~/plugins/wizardSteps").Include(
                      "~/Scripts/plugins/staps/jquery.steps.min.js"));

            // Inspinia script
            bundles.Add(new ScriptBundle("~/bundles/inspinia").Include(
                      "~/Scripts/plugins/metisMenu/metisMenu.min.js",
                      "~/Scripts/plugins/pace/pace.min.js",
                      "~/Scripts/app/inspinia.js"));

            // Inspinia skin config script
            bundles.Add(new ScriptBundle("~/bundles/skinConfig").Include(
                      "~/Scripts/app/skin.config.min.js"));

            // SlimScroll
            bundles.Add(new ScriptBundle("~/plugins/slimScroll").Include(
                      "~/Scripts/plugins/slimscroll/jquery.slimscroll.min.js"));

            // dataTables css styles
            bundles.Add(new StyleBundle("~/Content/plugins/dataTables/dataTablesStyles").Include(
                      "~/Content/plugins/dataTables/datatables.min.css"));

            // dataTables 
            bundles.Add(new ScriptBundle("~/plugins/dataTables").Include(
                      "~/Scripts/plugins/dataTables/datatables.min.js"));

            // TradingView
            bundles.Add(new ScriptBundle("~/plugins/tradingView").Include(
                      "~/Scripts/plugins/tradingView/charting_library/charting_library.min.js",
                      "~/Scripts/plugins/tradingView/datafeeds/udf/dist/polyfills.js",
                      "~/Scripts/plugins/tradingView/datafeeds/udf/dist/bundle.js"));

            bundles.IgnoreList.Clear();

            BundleTable.EnableOptimizations = true;
        }
    }
}