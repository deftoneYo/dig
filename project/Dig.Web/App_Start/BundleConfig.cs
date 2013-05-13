using System.Web;
using System.Web.Optimization;

namespace Dig.Web
{
    public class BundleConfig
    {
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
						"~/Scripts/jQuery/jquery-1.8.2*"));

			bundles.Add(new ScriptBundle("~/bundles/jQueryUi.1.10.1").Include(
						"~/Scripts/jQueryUi.1.10.1/js/jquery-ui*"));


            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            bundles.Add(new StyleBundle("~/Content/css").Include("~/Content/site.css"));

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

			bundles.Add(new ScriptBundle("~/bundles/kendoUi").Include(
						"~/Scripts/kendoUi.2012.3.1114/js/kendo.web.js"));

			bundles.Add(new ScriptBundle("~/bundles/kendoUi.2012.3.1114").Include(
						"~/Scripts/kendoUi.2012.3.1114/js/kendo*"


                        ));

			bundles.Add(new StyleBundle("~/Content/kendoUi.2012.3.1114").Include(
						"~/Scripts/kendoUi.2012.3.1114/styles/kendo.common.css",
						"~/Scripts/kendoUi.2012.3.1114/styles/kendo.default.css"));

			bundles.Add(new ScriptBundle("~/bundles/kendoUigrid").Include(
						"~/Scripts/kendoUi.2012.3.1114/js/kendo.core.js",
						"~/Scripts/kendoUi.2012.3.1114/js/kendo.data.odata.js",
						"~/Scripts/kendoUi.2012.3.1114/js/kendo.data.xml.js",
						"~/Scripts/kendoUi.2012.3.1114/js/kendo.data.js",
						"~/Scripts/kendoUi.2012.3.1114/js/kendo.fx.js",
						"~/Scripts/kendoUi.2012.3.1114/js/kendo.popup.js",
						"~/Scripts/kendoUi.2012.3.1114/js/kendo.list.js",
						"~/Scripts/kendoUi.2012.3.1114/js/kendo.calendar.js",
						"~/Scripts/kendoUi.2012.3.1114/js/kendo.datepicker.js",
						"~/Scripts/kendoUi.2012.3.1114/js/kendo.numerictextbox.js",
						"~/Scripts/kendoUi.2012.3.1114/js/kendo.validator.js",
						"~/Scripts/kendoUi.2012.3.1114/js/kendo.binder.js",
						"~/Scripts/kendoUi.2012.3.1114/js/kendo.dropdownlist.js",
						"~/Scripts/kendoUi.2012.3.1114/js/kendo.filtermenu.js",
						"~/Scripts/kendoUi.2012.3.1114/js/kendo.pager.js",
						"~/Scripts/kendoUi.2012.3.1114/js/kendo.sortable.js",
						"~/Scripts/kendoUi.2012.3.1114/js/kendo.draganddrop.js",
						"~/Scripts/kendoUi.2012.3.1114/js/kendo.groupable.js",
						"~/Scripts/kendoUi.2012.3.1114/js/kendo.editable.js",
						"~/Scripts/kendoUi.2012.3.1114/js/kendo.selectable.js",
						"~/Scripts/kendoUi.2012.3.1114/js/kendo.resizable.js",
						"~/Scripts/kendoUi.2012.3.1114/js/kendo.reorderable.js",
						"~/Scripts/kendoUi.2012.3.1114/js/kendo.grid.js"));

		}
    }
}