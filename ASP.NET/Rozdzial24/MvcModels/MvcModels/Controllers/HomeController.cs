using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using MvcModels.Models;

namespace MvcModels.Controllers {
    public class HomeController : Controller {
        private Person[] personData = {
           new Person {PersonId = 1, FirstName = "Adam", LastName = "Nowak",  
                Role = Role.Administrator}, 
            new Person {PersonId = 2, FirstName = "Janina", LastName = "Grabowska",  
                Role = Role.Użytkownik}, 
            new Person {PersonId = 3, FirstName = "Jan", LastName = "Kowalski",  
                Role = Role.Użytkownik}, 
            new Person {PersonId = 4, FirstName = "Anna", LastName = "Bobrowska",  
                Role = Role.Gość}
        };

        public ActionResult Index(int id = 1) {
            Person dataItem = personData.Where(p => p.PersonId == id).First();
            return View(dataItem);
        }

        public ActionResult CreatePerson() {
            return View(new Person());
        }

        [HttpPost]
        public ActionResult CreatePerson(Person model) {
            return View("Index", model);
        }

        public ActionResult DisplaySummary(
            [Bind(Prefix = "HomeAddress", Exclude = "Country")]AddressSummary summary) {
            return View(summary);
        }

        public ActionResult Names(IList<string> names) {
            names = names ?? new List<string>();
            return View(names);
        }

        public ActionResult Address() {
            IList<AddressSummary> addresses = new List<AddressSummary>();
            UpdateModel(addresses);
            return View(addresses);
        }
    }
}
