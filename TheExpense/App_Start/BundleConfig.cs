﻿using System.Web;
using System.Web.Optimization;

namespace TheExpense
{
    public class BundleConfig
    {
        // For more information on bundling, visit http://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery-{version}.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/jquery.validate*"));

            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at http://modernizr.com to pick only the tests you need.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                      "~/Scripts/bootstrap.js",
                      "~/Scripts/respond.js"));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/bootstrap.css",
                      "~/Content/site.css"));

            // For Jqgrid
            bundles.Add(new ScriptBundle("~/bundles/jqgrid").Include(
                "~/Scripts/JqGrid/jquery.jqGrid.min.js",
                "~/Scripts/JqGrid/jquery.jqGrid.src.js"));
            bundles.Add(new StyleBundle("~/Content/jqgrid").Include(
                "~/Content/JqGrid/ui.jqGrid.css"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryui").Include(
                "~/Scripts/jquery-ui-1.10.4.js",
                "~/Scripts/jquery-ui-1.10.4.min.js"));

            bundles.Add(new StyleBundle("~/Content/jqueryui").Include(
               "~/Content/jquery-ui-1.10.4.custom.css",
               "~/Content/jquery-ui-1.10.4.custom.min.css"));

            bundles.Add(new ScriptBundle("~/bundles/ajax").Include(
              //  "~/Scripts/jquery.validate.unobtrusive.js",
              //"~/Scripts/jquery.validate.unobtrusive.min.js",
              "~/Scripts/jquery.unobtrusive-ajax.js"//,
               //"~/Scripts/jquery.unobtrusive-ajax.min.js"
               ));
        }
    }
}