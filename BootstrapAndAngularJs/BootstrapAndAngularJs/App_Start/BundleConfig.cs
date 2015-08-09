﻿using System.Web;
using System.Web.Optimization;

namespace BootstrapAndAngularJs
{
    public class BundleConfig
    {
        // For more information on bundling, visit http://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/myScripts").Include(
                        "~/Scripts/jquery-{version}.js",
                        "~/Scripts/bootstrap.js",
                        "~/Scripts/angular.js"
                        ));

            bundles.Add(new ScriptBundle("~/bundles/angularApp").Include(
                    "~/ScriptsApp/Views/mainApp.js",
                    "~/ScriptsApp/Views/Home/personCtrl.js"
                    ));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/bootstrap.css",
                      "~/Content/site.css"));
        }
    }
}
