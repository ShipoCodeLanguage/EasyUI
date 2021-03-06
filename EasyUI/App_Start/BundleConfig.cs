﻿using System.Web;
using System.Web.Optimization;

namespace EasyUI
{
    public class BundleConfig
    {
        // 有关绑定的详细信息，请访问 http://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery-{version}.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/jquery.validate*"));

            bundles.Add(new ScriptBundle("~/bundles/home").Include("~/Scripts/home.js"));

            //EasyUI
            bundles.Add(new StyleBundle("~/Content/themes/black/css").Include("~/Content/themes/black/easyui.css"));
            bundles.Add(new StyleBundle("~/Content/themes/default/css").Include("~/Content/themes/default/easyui.css"));
            bundles.Add(new StyleBundle("~/Content/themes/bootstrap/css").Include("~/Content/themes/bootstrap/easyui.css"));
            bundles.Add(new StyleBundle("~/Content/themes/gray/css").Include("~/Content/themes/gray/easyui.css"));

            bundles.Add(new StyleBundle("~/Content/themes/material/css").Include("~/Content/themes/material/easyui.css"));
            bundles.Add(new StyleBundle("~/Content/themes/material-blue/css").Include("~/Content/themes/material-blue/easyui.css"));
            bundles.Add(new StyleBundle("~/Content/themes/material-teal/css").Include("~/Content/themes/material-teal/easyui.css"));
            bundles.Add(new StyleBundle("~/Content/themes/metro/css").Include("~/Content/themes/metro/easyui.css"));


            // 使用要用于开发和学习的 Modernizr 的开发版本。然后，当你做好
            // 生产准备时，请使用 http://modernizr.com 上的生成工具来仅选择所需的测试。
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                        "~/Content/themes/icon.css",
                      "~/Content/site.css"));



        }
    }
}
