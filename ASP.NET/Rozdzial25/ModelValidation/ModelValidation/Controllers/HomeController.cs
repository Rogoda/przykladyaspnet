using System;
using System.Web.Mvc;
using ModelValidation.Models;

namespace ModelValidation.Controllers {
    public class HomeController : Controller {

        public ViewResult MakeBooking() {
            return View(new Appointment { Date = DateTime.Now });
        }

        [HttpPost]
        public ViewResult MakeBooking(Appointment appt) {
            if (ModelState.IsValid) {
                // w rzeczywistym projekcie tutaj będą polecenia odpowiedzialne
                // za umieszczenie nowego obiektu Appointment w repozytorium
                return View("Completed", appt);
            } else {
                return View();
            }
        }

        public JsonResult ValidateDate(string Date) {
            DateTime parsedDate;

            if (!DateTime.TryParse(Date, out parsedDate)) {
                return Json("Proszę podać prawidłową datę (rrrr-mm-dd).",
                    JsonRequestBehavior.AllowGet);
            } else if (DateTime.Now > parsedDate) {
                return Json("Prosze podać przyszłą datę.",
                    JsonRequestBehavior.AllowGet);
            } else {
                return Json(true, JsonRequestBehavior.AllowGet);
            }
        }


    }
}
