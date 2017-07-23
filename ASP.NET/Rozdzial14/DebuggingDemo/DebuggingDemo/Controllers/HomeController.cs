using System.Web.Mvc;

namespace DebuggingDemo.Controllers {
    public class HomeController : Controller {

        public ActionResult Index() {
            int firstVal = 10;
            int secondVal = 0;
            int result = firstVal / 2;

            // poniższe polecenie zostało poprzedzone znakiem komentarza
            //ViewBag.Message = "Witamy na platformie ASP.NET MVC!";

            return View(result);
        }
    }
}
