using System.Data.Entity;
using Microsoft.AspNet.Identity.EntityFramework;

namespace Test_Locator.Models
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public DbSet<Equipment> Equipments { get; set; }
        public DbSet<EquipType> EquipTypes { get; set; }

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