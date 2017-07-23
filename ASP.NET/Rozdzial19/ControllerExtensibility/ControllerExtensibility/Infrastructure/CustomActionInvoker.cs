using System.Web.Mvc;

namespace ControllerExtensibility.Infrastructure {

    public class CustomActionInvoker : IActionInvoker {

        public bool InvokeAction(ControllerContext controllerContext,
                string actionName) {

            if (actionName == "Index") {
                controllerContext.HttpContext.
                    Response.Write("Wynik działania akcji Index.");
                return true;
            } else {
                return false;
            }
        }
    }
}
