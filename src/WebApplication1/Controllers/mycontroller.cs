﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication1.Controllers
{
    public class mycontroller : Controller
    {
        public ActionResult Detail()
        {
            if (DateTime.Today.DayOfWeek==DayOfWeek.Tuesday)
            {
                return Redirect("/");
            }
            return Content("Hello from my controller");
        }
    }
}