﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     此代码由工具生成。
//     运行时版本:4.0.30319.42000
//
//     对此文件的更改可能会导致不正确的行为，并且如果
//     重新生成代码，这些更改将会丢失。
// </auto-generated>
//------------------------------------------------------------------------------

namespace ASP
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    using System.Net;
    using System.Text;
    using System.Web;
    using System.Web.Helpers;
    using System.Web.Mvc;
    using System.Web.Mvc.Ajax;
    using System.Web.Mvc.Html;
    using System.Web.Optimization;
    using System.Web.Routing;
    using System.Web.Security;
    using System.Web.UI;
    using System.Web.WebPages;
    using Mcally.UI.Web;
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/Home/Index.cshtml")]
    public partial class _Views_Home_Index_cshtml : System.Web.Mvc.WebViewPage<dynamic>
    {
        public _Views_Home_Index_cshtml()
        {
        }
        public override void Execute()
        {
WriteLiteral("<!DOCTYPE html>\r\n<html>\r\n<head>\r\n    <meta");

WriteLiteral(" charset=\"utf-8\"");

WriteLiteral(">\r\n    <meta");

WriteLiteral(" name=\"viewport\"");

WriteLiteral(" content=\"width=device-width, initial-scale=1.0, maximum-scale=1.0\"");

WriteLiteral(">\r\n\r\n    <title>Mcally管理系统</title>\r\n    <meta");

WriteLiteral(" name=\"keywords\"");

WriteLiteral(" content=\"Mcally开源,若依框架,若依系统,ruoyi\"");

WriteLiteral(">\r\n    <meta");

WriteLiteral(" name=\"description\"");

WriteLiteral(" content=\"Mcally基于SpringBoot2.0的权限管理系统 易读易懂、界面简洁美观。 核心技术采用Spring、MyBatis、Shiro没有任" +
"何其它重度依赖\"");

WriteLiteral(">\r\n    <link");

WriteAttribute("href", Tuple.Create(" href=\"", 381), Tuple.Create("\"", 419)
, Tuple.Create(Tuple.Create("", 388), Tuple.Create<System.Object, System.Int32>(Href("~/Content/css/bootstrap.min.css")
, 388), false)
);

WriteLiteral(" rel=\"stylesheet\"");

WriteLiteral(" />\r\n    <link");

WriteAttribute("href", Tuple.Create(" href=\"", 451), Tuple.Create("\"", 495)
, Tuple.Create(Tuple.Create("", 458), Tuple.Create<System.Object, System.Int32>(Href("~/Scripts/ajax/libs/iCheck/custom.css")
, 458), false)
);

WriteLiteral(" rel=\"stylesheet\"");

WriteLiteral(" />\r\n    <link");

WriteAttribute("href", Tuple.Create(" href=\"", 527), Tuple.Create("\"", 568)
, Tuple.Create(Tuple.Create("", 534), Tuple.Create<System.Object, System.Int32>(Href("~/Content/css/font-awesome.min.css")
, 534), false)
);

WriteLiteral(" rel=\"stylesheet\"");

WriteLiteral(" />\r\n    <link");

WriteAttribute("href", Tuple.Create(" href=\"", 600), Tuple.Create("\"", 632)
, Tuple.Create(Tuple.Create("", 607), Tuple.Create<System.Object, System.Int32>(Href("~/Content/css/animate.css")
, 607), false)
);

WriteLiteral(" rel=\"stylesheet\"");

WriteLiteral(" />\r\n    <link");

WriteAttribute("href", Tuple.Create(" href=\"", 664), Tuple.Create("\"", 694)
, Tuple.Create(Tuple.Create("", 671), Tuple.Create<System.Object, System.Int32>(Href("~/Content/css/style.css")
, 671), false)
);

WriteLiteral(" rel=\"stylesheet\"");

WriteLiteral(" />\r\n    <link");

WriteAttribute("href", Tuple.Create(" href=\"", 726), Tuple.Create("\"", 760)
, Tuple.Create(Tuple.Create("", 733), Tuple.Create<System.Object, System.Int32>(Href("~/Content/css/login.min.css")
, 733), false)
);

WriteLiteral(" rel=\"stylesheet\"");

WriteLiteral(" />\r\n\r\n    <style");

WriteLiteral(" type=\"text/css\"");

WriteLiteral(">\r\n        label.error {\r\n            position: inherit;\r\n        }\r\n    </style>" +
"\r\n    <script>\r\n        if (window.top !== window.self) { window.top.location = " +
"window.location };\r\n    </script>\r\n</head>\r\n\r\n<body");

WriteLiteral(" class=\"signin\"");

WriteLiteral(">\r\n\r\n    <div");

WriteLiteral(" class=\"signinpanel\"");

WriteLiteral(">\r\n        <div");

WriteLiteral(" class=\"row\"");

WriteLiteral(">\r\n            <div");

WriteLiteral(" class=\"col-sm-7\"");

WriteLiteral(">\r\n                <div");

WriteLiteral(" class=\"signin-info\"");

WriteLiteral(">\r\n                    <div");

WriteLiteral(" class=\"logopanel m-b\"");

WriteLiteral(">\r\n                        ");

WriteLiteral("\r\n                    </div>\r\n                    <div");

WriteLiteral(" class=\"m-b\"");

WriteLiteral("></div>\r\n                    <h4>欢迎使用 <strong>Mcally 后台管理系统</strong></h4>\r\n      " +
"              <ul");

WriteLiteral(" class=\"m-b\"");

WriteLiteral(">\r\n                        <li><i");

WriteLiteral(" class=\"fa fa-arrow-circle-o-right m-r-xs\"");

WriteLiteral("></i> SpringBoot</li>\r\n                        <li><i");

WriteLiteral(" class=\"fa fa-arrow-circle-o-right m-r-xs\"");

WriteLiteral("></i> Mybatis</li>\r\n                        <li><i");

WriteLiteral(" class=\"fa fa-arrow-circle-o-right m-r-xs\"");

WriteLiteral("></i> Shiro</li>\r\n                        <li><i");

WriteLiteral(" class=\"fa fa-arrow-circle-o-right m-r-xs\"");

WriteLiteral("></i> Thymeleaf</li>\r\n                        <li><i");

WriteLiteral(" class=\"fa fa-arrow-circle-o-right m-r-xs\"");

WriteLiteral("></i> Bootstrap</li>\r\n                    </ul>\r\n                    <strong>还没有账" +
"号？ <a");

WriteLiteral(" href=\"#\"");

WriteLiteral(">立即注册&raquo;</a></strong>\r\n                </div>\r\n            </div>\r\n          " +
"  <div");

WriteLiteral(" class=\"col-sm-5\"");

WriteLiteral(">\r\n                <form");

WriteLiteral(" id=\"signupForm\"");

WriteLiteral(">\r\n                    <h4");

WriteLiteral(" class=\"no-margins\"");

WriteLiteral(">登录：</h4>\r\n                    <p");

WriteLiteral(" class=\"m-t-md\"");

WriteLiteral(">你若不离不弃，我必生死相依</p>\r\n                    <input");

WriteLiteral(" type=\"text\"");

WriteLiteral(" name=\"username\"");

WriteLiteral(" class=\"form-control uname\"");

WriteLiteral(" placeholder=\"用户名\"");

WriteLiteral(" value=\"admin\"");

WriteLiteral(" />\r\n                    <input");

WriteLiteral(" type=\"password\"");

WriteLiteral(" name=\"password\"");

WriteLiteral(" class=\"form-control pword m-b\"");

WriteLiteral(" placeholder=\"密码\"");

WriteLiteral(" value=\"admin123\"");

WriteLiteral(" />\r\n                    <div");

WriteLiteral(" class=\"row\"");

WriteLiteral(">\r\n                        <div");

WriteLiteral(" class=\"col-xs-6\"");

WriteLiteral(">\r\n                            <input");

WriteLiteral(" type=\"text\"");

WriteLiteral(" name=\"validateCode\"");

WriteLiteral(" class=\"form-control code\"");

WriteLiteral(" placeholder=\"验证码\"");

WriteLiteral(" maxlength=\"5\"");

WriteLiteral(">\r\n                        </div>\r\n                        ");

WriteLiteral("\r\n                    </div>\r\n                    <div");

WriteLiteral(" class=\"checkbox-custom\"");

WriteLiteral(">\r\n                        <input");

WriteLiteral(" type=\"checkbox\"");

WriteLiteral(" id=\"rememberme\"");

WriteLiteral(" name=\"rememberme\"");

WriteLiteral("> <label");

WriteLiteral(" for=\"rememberme\"");

WriteLiteral(">记住我</label>\r\n                    </div>\r\n                    <button");

WriteLiteral(" class=\"btn btn-success btn-block\"");

WriteLiteral(" id=\"btnSubmit\"");

WriteLiteral(" data-loading=\"正在验证登录，请稍后...\"");

WriteLiteral(">登录</button>\r\n                </form>\r\n            </div>\r\n        </div>\r\n      " +
"  <div");

WriteLiteral(" class=\"signup-footer\"");

WriteLiteral(">\r\n            <div");

WriteLiteral(" class=\"pull-left\"");

WriteLiteral(">\r\n                &copy; 2018 All Rights Reserved. Mcally <br>\r\n                " +
"<a");

WriteLiteral(" href=\"http://www.miitbeian.gov.cn/\"");

WriteLiteral(" target=\"_blank\"");

WriteLiteral(" rel=\"nofollow\"");

WriteLiteral(">粤ICP备18046899号</a><br>\r\n            </div>\r\n        </div>\r\n    </div>\r\n    <scr" +
"ipt");

WriteAttribute("src", Tuple.Create(" src=\"", 3828), Tuple.Create("\"", 3860)
, Tuple.Create(Tuple.Create("", 3834), Tuple.Create<System.Object, System.Int32>(Href("~/Scripts/js/jquery.min.js")
, 3834), false)
);

WriteLiteral("></script>\r\n    <script");

WriteAttribute("src", Tuple.Create(" src=\"", 3884), Tuple.Create("\"", 3919)
, Tuple.Create(Tuple.Create("", 3890), Tuple.Create<System.Object, System.Int32>(Href("~/Scripts/js/bootstrap.min.js")
, 3890), false)
);

WriteLiteral("></script>\r\n    <script");

WriteAttribute("src", Tuple.Create(" src=\"", 3943), Tuple.Create("\"", 4000)
, Tuple.Create(Tuple.Create("", 3949), Tuple.Create<System.Object, System.Int32>(Href("~/Scripts/ajax/libs/validate/jquery.validate.min.js")
, 3949), false)
);

WriteLiteral("></script>\r\n    <script");

WriteAttribute("src", Tuple.Create(" src=\"", 4024), Tuple.Create("\"", 4068)
, Tuple.Create(Tuple.Create("", 4030), Tuple.Create<System.Object, System.Int32>(Href("~/Scripts/ajax/libs/layer/layer.min.js")
, 4030), false)
);

WriteLiteral("></script>\r\n    <script");

WriteAttribute("src", Tuple.Create(" src=\"", 4092), Tuple.Create("\"", 4145)
, Tuple.Create(Tuple.Create("", 4098), Tuple.Create<System.Object, System.Int32>(Href("~/Scripts/ajax/libs/validate/messages_zh.min.js")
, 4098), false)
);

WriteLiteral("></script>\r\n    <script");

WriteAttribute("src", Tuple.Create(" src=\"", 4169), Tuple.Create("\"", 4220)
, Tuple.Create(Tuple.Create("", 4175), Tuple.Create<System.Object, System.Int32>(Href("~/Scripts/ajax/libs/blockUI/jquery.blockUI.js")
, 4175), false)
);

WriteLiteral("></script>\r\n    <script");

WriteAttribute("src", Tuple.Create(" src=\"", 4244), Tuple.Create("\"", 4277)
, Tuple.Create(Tuple.Create("", 4250), Tuple.Create<System.Object, System.Int32>(Href("~/Scripts/ruoyi/js/ry-ui.js")
, 4250), false)
);

WriteLiteral("></script>\r\n    <script");

WriteAttribute("src", Tuple.Create(" src=\"", 4301), Tuple.Create("\"", 4331)
, Tuple.Create(Tuple.Create("", 4307), Tuple.Create<System.Object, System.Int32>(Href("~/Scripts/ruoyi/login.js")
, 4307), false)
);

WriteLiteral("></script>\r\n    <script");

WriteAttribute("src", Tuple.Create(" src=\"", 4355), Tuple.Create("\"", 4401)
, Tuple.Create(Tuple.Create("", 4361), Tuple.Create<System.Object, System.Int32>(Href("~/Scripts/ajax/libs/iCheck/icheck.min.js")
, 4361), false)
);

WriteLiteral("></script>\r\n</body>\r\n</html>\r\n\r\n\r\n");

        }
    }
}
#pragma warning restore 1591
