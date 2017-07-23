using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using HelperMethods.Models;

namespace HelperMethods.Controllers {
    public class PeopleController : Controller {
        private Person[] personData = {
            new Person {FirstName = "Adam", LastName = "Nowak", Role = Role.Administrator}, 
            new Person {FirstName = "Janina", LastName = "Grabowska", Role = Role.Użytkownik}, 
            new Person {FirstName = "Jan", LastName = "Kowalski", Role = Role.Użytkownik}, 
            new Person {FirstName = "Anna", LastName = "Bobrowska", Role = Role.Gość}
        };

        public ActionResult Index() {
            return View();
        }

        public ActionResult GetPeopleData(string selectedRole = "Wszyscy") {
            IEnumerable<Person> data = personData;
            if (selectedRole != "Wszyscy") {
                Role selected = (Role)Enum.Parse(typeof(Role), selectedRole);
                data = personData.Where(p => p.Role == selected);
            }
            if (Request.IsAjaxRequest()) {
                var formattedData = data.Select(p => new {
                    FirstName = p.FirstName,
                    LastName = p.LastName,
                    Role = Enum.GetName(typeof(Role), p.Role)
                });
                return Json(formattedData, JsonRequestBehavior.AllowGet);
            } else {
                return PartialView(data);
            }
        }

        public ActionResult GetPeople(string selectedRole = "Wszyscy") {
            return View((object)selectedRole);
        }
    }
}
