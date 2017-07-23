using System;
using System.Web.Mvc;
using ClientFeatures.Models;

namespace ClientFeatures.Controllers {
    public class HomeController : Controller {

        public ViewResult MakeBooking() {
            return View(new Appointment {
                ClientName = "Kowalski",
                TermsAccepted = true
            });
        }

        [HttpPost]
        public JsonResult MakeBooking(Appointment appt) {
            // w rzeczywistym projekcie tutaj będą polecenia odpowiedzialne
            // za umieszczenie nowego obiektu Appointment w repozytorium
            return Json(appt, JsonRequestBehavior.AllowGet);
        }
    }
}
