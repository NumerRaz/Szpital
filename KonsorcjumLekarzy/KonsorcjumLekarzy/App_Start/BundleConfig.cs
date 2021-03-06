﻿using System.Web;
using System.Web.Optimization;

namespace KonsorcjumLekarzy
{
    public class BundleConfig
    {
        public static void RegisterBundles(BundleCollection bundles)
        {
            var initScript = new ScriptBundle("~/bundles/initScript")
                .Include("~/Scripts/jquery-{version}.js")
                .Include("~/Scripts/jquery.validate*")
                .Include("~/Scripts/modernizr-*")
                .Include("~/Scripts/bootstrap.js",
                    "~/Scripts/respond.js")
                .Include("~/Scripts/angular.js");
            
            var initStyle = new StyleBundle("~/Content/css")
                .Include("~/Content/bootstrap.css",
                      "~/Content/site.css");

            var angular = new StyleBundle("~/angular")
                .Include("~/Angular/app.js");

            bundles.Add(initScript);
            bundles.Add(initStyle);
        }
    }
}
