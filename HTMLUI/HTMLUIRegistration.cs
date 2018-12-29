﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HTMLUI
{
    public class MESAreaRegistration : AreaRegistration
    {
        public override string AreaName
        {
            get
            {
                return "HTMLUI";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context)
        {
            context.MapRoute(
                "MES_default",
                "HTMLUI/{controller}/{action}/{id}",
                new { controller = "Home", action = "Index", id = UrlParameter.Optional },
                namespaces: new string[] { "Mcally.UI.Web.Controllers" }
            );
        }
    }
}