using System;
using System.Diagnostics;
using System.Web.Mvc;
using Filters.Infrastructure;

namespace Filters.Controllers {
    public class HomeController : Controller {
        private Stopwatch timer;

        [Authorize(Users = "admin")]
        public string Index() {
            return "To jest metoda akcji Index kontrolera Home";
        }

        [GoogleAuth]
        [Authorize(Users = "bob@google.com")]
        public string List() {
            return "To jest metoda akcji List kontrolera Home";
        }

        [HandleError(ExceptionType = typeof(ArgumentOutOfRangeException),
            View = "RangeError")]
        public string RangeTest(int id) {
            if (id > 100) {
                return String.Format("Wartość id wynosi: {0}", id);
            } else {
                throw new ArgumentOutOfRangeException("id", id, "");
            }
        }

        public string FilterTest() {
            return "To jest akcja FilterTest";
        }

        protected override void OnActionExecuting(ActionExecutingContext filterContext) {
            timer = Stopwatch.StartNew();
        }

        protected override void OnResultExecuted(ResultExecutedContext filterContext) {
            timer.Stop();
            filterContext.HttpContext.Response.Write(
                    string.Format("<div>Całkowity czas wykonania: {0}</div>",
                        timer.Elapsed.TotalSeconds));
        }
    }
}
