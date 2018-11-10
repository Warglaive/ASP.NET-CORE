using IntroMvc.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace IntroMvc.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public DbSet<Cat> Cats { get; set; }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=WARGLAIVE\\SQLEXPRESS;Database=CatDb;Integrated Security=true;");
        }
    }
}
