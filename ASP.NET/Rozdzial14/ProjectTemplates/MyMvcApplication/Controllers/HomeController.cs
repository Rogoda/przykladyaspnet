using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MyMvcApplication.Controllers {
    public class HomeController : Controller {
        public ActionResult Index() {
            return View();
        }

        public ActionResult About() {
            ViewBag.Message = "Strona z informacjami dodatkowymi.";

            return View();
        }

        public ActionResult Contact() {
            ViewBag.Message = "Strona z informacjami kontaktowymi.";

            return View();
        }
    }
}