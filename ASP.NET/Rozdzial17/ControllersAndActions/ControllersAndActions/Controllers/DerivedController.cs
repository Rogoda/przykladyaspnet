﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ControllersAndActions.Infrastructure;

namespace ControllersAndActions.Controllers {
    public class DerivedController : Controller {

        public ActionResult Index() {
            ViewBag.Message = "Pozdrowienia z metody Index w klasie DerivedController";
            return View("MyView");
        }

        public ActionResult ProduceOutput() {
            return Redirect("/Basic/Index");
        } 


    }
}
