using Microsoft.AspNet.Identity.EntityFramework;

namespace MyMvcApplication.Models
{
    // dane profilu dla użytkownika można dodać, dodając więcej właściwości do własnej klasy ApplicationUser, więcej informacji można znaleźć na stronie http://go.microsoft.com/fwlink/?LinkID=317594
    public class ApplicationUser : IdentityUser
    {
    }

    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext()
            : base("DefaultConnection")
        {
        }
    }
}