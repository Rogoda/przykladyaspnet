using System;
using System.ComponentModel.DataAnnotations;
using ModelValidation.Models;

namespace ModelValidation.Infrastructure {
    public class NoJoeOnMondaysAttribute : ValidationAttribute {

        public NoJoeOnMondaysAttribute() {
            ErrorMessage = "Nowak nie może rezerwować w poniedziałki.";
        }

        public override bool IsValid(object value) {
            Appointment app = value as Appointment;
            if (app == null || string.IsNullOrEmpty(app.ClientName) ||
                    app.Date == null) {
                // nie mamy modelu właściwego typu lub nie mamy
                // wartości wymaganych właściwości ClientName oraz Date
                return true;
            } else {
                return !(app.ClientName == "Nowak" &&
                    app.Date.DayOfWeek == DayOfWeek.Monday);
            }
        }
    }
}
