using System.IO;
using System.Web.Mvc;

namespace Views.Infrastructure {
    public class DebugDataView : IView {

        public void Render(ViewContext viewContext, TextWriter writer) {

            Write(writer, "---Dane routingu---");
            foreach (string key in viewContext.RouteData.Values.Keys) {
                Write(writer, "Klucz: {0}, Wartość: {1}",
                    key, viewContext.RouteData.Values[key]);
            }

            Write(writer, "---Dane widoku---");
            foreach (string key in viewContext.ViewData.Keys) {
                Write(writer, "Klucz: {0}, Wartość: {1}", key,
                    viewContext.ViewData[key]);
            }
        }

        private void Write(TextWriter writer, string template, params object[] values) {
            writer.Write(string.Format(template, values) + "<p/>");
        }
    }
}
