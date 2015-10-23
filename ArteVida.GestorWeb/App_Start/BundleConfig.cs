﻿using System.Web;
using System.Web.Optimization;

namespace ArteVida.GestorWeb
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

           

            // Set EnableOptimizations to false for debugging. For more information,
            // visit http://go.microsoft.com/fwlink/?LinkId=301862
            BundleTable.EnableOptimizations = true;

            bundles.Add(new ScriptBundle("~/bundles/kendo").Include(
             "~/Scripts/kendo/2015.2.624/kendo.all.min.js",
             // "~/Scripts/kendo/kendo.timezones.min.js", // uncomment if using the Scheduler
             "~/Scripts/kendo/2015.2.624/kendo.aspnetmvc.min.js"));


            bundles.Add(new StyleBundle("~/Content/kendo/css").Include(
            "~/Content/kendo/2015.2.624/kendo.common-bootstrap.min.css",
            "~/Content/kendo/2015.2.624/kendo.bootstrap.min.css"));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                     "~/Content/bootstrap.css",
                     "~/Content/kurtlewin.css"));

            bundles.IgnoreList.Clear();
        }
    }
}
