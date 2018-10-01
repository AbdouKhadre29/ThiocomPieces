using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Optimization;

namespace ThiocomPieces.App_Start
{
    public class BundleConfig
    {
        public static void RegisterBundles(BundleCollection bundles)
        {
            //bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
            //          "~/Content/jquery-3.3.31.min.js",
            //          "~/Scripts/bootstrap.js"));

            //bundles.Add(new StyleBundle("~/Content/css").Include(
            //          "~/Content/bootstrap.min.css",
            //        //  "~/Content/jquery-ui.css",
            //          "~/Content/theme.css",
            //          "~/Content/datepicker.css"));

            // bootstrap
            bundles.Add(new StyleBundle("~/bundles/bootstrap-css")
                .Include("~/Content/bootstrap.css"));

            // jqueryui
            bundles.Add(new StyleBundle("~/bundles/jqueryui-css")
                .Include("~/Content/themes/base/core.css",
                        "~/Content/themes/base/datepicker.css",
                       "~/Content/themes/base/theme.css"));


            bundles.Add(new ScriptBundle("~/bundles/bootstrap-js")
                .Include("~/Scripts/jquery-3.3.1.js",
                         "~/Scripts/bootstrap.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryui-js")
                .Include("~/Scripts/jquery-ui-1.12.1.js",
                        "~/Scripts/datepicker.fr-FR.js"));


            bundles.Add(new ScriptBundle("~/bundles/validation-js")
                 .Include("~/Script/jquery.validate.js",
                         "~/Scripts/jquery.validate.unobtrusive.js"));
        }
    }
}