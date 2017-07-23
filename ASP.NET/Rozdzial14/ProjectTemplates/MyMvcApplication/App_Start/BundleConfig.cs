using System.Web;
using System.Web.Optimization;

namespace MyMvcApplication
{
    public class BundleConfig
    {
        // więcej informacji dotyczących tworzenia pakietów można znaleźć na stronie http://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery-{version}.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/jquery.validate*"));

            // użyj wersji deweloperskiej biblioteki Modernizr do nauki i opracowywania rozwiązań; następnie, kiedy wszystko będzie
            // gotowe do produkcji, wybierz tylko potrzebne testy za pomocą narzędzia kompilacji z witryny http://modernizr.com
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                      "~/Scripts/bootstrap.js",
                      "~/Scripts/respond.js"));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/bootstrap.css",
                      "~/Content/site.css"));
        }
    }
}
