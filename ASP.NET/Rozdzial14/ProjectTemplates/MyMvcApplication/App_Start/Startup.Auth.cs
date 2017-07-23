using Microsoft.AspNet.Identity;
using Microsoft.Owin;
using Microsoft.Owin.Security.Cookies;
using Owin;

namespace MyMvcApplication
{
    public partial class Startup
    {
        // więcej informacji dotyczących konfigurowania uwierzytelnienia można znaleźć na stronie http://go.microsoft.com/fwlink/?LinkId=301864
        public void ConfigureAuth(IAppBuilder app)
        {
            // zezwalaj aplikacji na przechowywanie w pliku cookie informacji o zalogowanym użytkowniku
            app.UseCookieAuthentication(new CookieAuthenticationOptions
            {
                AuthenticationType = DefaultAuthenticationTypes.ApplicationCookie,
                LoginPath = new PathString("/Account/Login")
            });
            // zezwalaj na tymczasowe przechowywanie w pliku cookie informacji o użytkowniku logującym się przy użyciu dostawcy logowania innego producenta
            app.UseExternalSignInCookie(DefaultAuthenticationTypes.ExternalCookie);

            // usuń znaczniki komentarza z poniższych wierszy, aby włączyć logowanie przy użyciu innych dostawców logowania
            //app.UseMicrosoftAccountAuthentication(
            //    clientId: "",
            //    clientSecret: "");

            //app.UseTwitterAuthentication(
            //   consumerKey: "",
            //   consumerSecret: "");

            //app.UseFacebookAuthentication(
            //   appId: "",
            //   appSecret: "");

            //app.UseGoogleAuthentication();
        }
    }
}