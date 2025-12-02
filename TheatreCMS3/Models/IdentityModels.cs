using System.Data.Entity;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using TheatreCMS3.Areas.Blog.Models;   // for BlogAuthor

namespace TheatreCMS3.Models
{
    // =======================
    // ApplicationUser
    // =======================
    public class ApplicationUser : IdentityUser
    {
        public async Task<ClaimsIdentity> GenerateUserIdentityAsync(UserManager<ApplicationUser> manager)
        {
            var userIdentity = await manager.CreateIdentityAsync(
                this,
                DefaultAuthenticationTypes.ApplicationCookie);

            // Add custom claims here if needed
            return userIdentity;
        }
    }

    // =======================
    // ApplicationDbContext
    // =======================
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        // IMPORTANT: this runs BEFORE any context is used
        // and tells EF to DROP + RECREATE if the model changes.
        static ApplicationDbContext()
        {
            Database.SetInitializer(
                new DropCreateDatabaseIfModelChanges<ApplicationDbContext>());
        }

        public ApplicationDbContext()
            : base("DefaultConnection", throwIfV1Schema: false)
        {
        }

        public static ApplicationDbContext Create()
        {
            return new ApplicationDbContext();
        }

        // Your tables
        public DbSet<BlogAuthor> BlogAuthors { get; set; }

        // Add more DbSet<T> here for other models
    }
}
