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
    }
}
