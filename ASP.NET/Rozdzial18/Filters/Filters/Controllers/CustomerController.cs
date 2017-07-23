using System.Web.Mvc;
using Filters.Infrastructure;

namespace Filters.Controllers {
    [SimpleMessage(Message = "A")]
    public class CustomerController : Controller {

        public string Index() {
            return "To jest kontroler Customer";
        }

        [CustomOverrideActionFilters]
        [SimpleMessage(Message = "B")]
        public string OtherAction() {
            return "To jest akcja OtherAction w kontrolerze Customer";
        }
    }
}
