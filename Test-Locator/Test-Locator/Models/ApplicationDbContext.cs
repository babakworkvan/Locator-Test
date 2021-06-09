using System.Data.Entity;
using Microsoft.AspNet.Identity.EntityFramework;

namespace Test_Locator.Models
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public DbSet<Printer> Printers { get; set; }

        public DbSet<Facility> Facilities { get; set; }


        public ApplicationDbContext()
            : base("DefaultConnection", throwIfV1Schema: false)
        {
        }

        public static ApplicationDbContext Create()
        {
            return new ApplicationDbContext();
        }
    }
}