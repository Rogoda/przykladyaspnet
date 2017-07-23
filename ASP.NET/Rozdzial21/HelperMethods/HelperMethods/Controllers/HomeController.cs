using System.Web.Mvc;
using HelperMethods.Models;

namespace HelperMethods.Controllers {
    public class HomeController : Controller {

        public ActionResult Index() {

            ViewBag.Fruits = new string[] { "Jabłka", "Pomarańcze", "Gruszki" };
            ViewBag.Cities = new string[] { "Nowy Jork", "Londyn", "Paryż" };

            string message = "To jest element HTML: <input>";

            return View((object)message);
        }

        public ActionResult CreatePerson() {
            return View(new Person());
        }

        [HttpPost]
        public ActionResult CreatePerson(Person person) {
            return View(person);
        }
    }
}
