using System.Web.Mvc;
using ControllersAndActions.Controllers;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ControllersAndActions.Tests {
    [TestClass]
    public class ActionTests {

        [TestMethod]
        public void ControllerTest() {

            // przygotowanie - utworzenie kontrolera
            ExampleController target = new ExampleController();

            // działanie - wywołanie metody akcji
            HttpStatusCodeResult result = target.StatusCode();

            // asercje - sprawdzenie wyniku
            Assert.AreEqual(401, result.StatusCode);
        } 

        [TestMethod]
        public void ViewSelectionTest() {

            // przygotowanie - utworzenie kontrolera
            ExampleController target = new ExampleController();

            // działanie - wywołanie metody akcji
            ViewResult result = target.Index();

            // asercje - sprawdzenie wyniku
            Assert.AreEqual("", result.ViewName);
            Assert.IsInstanceOfType(result.ViewData.Model, typeof(System.DateTime));
        }
    }
}
