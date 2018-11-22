using System;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.DependencyInjection;

namespace Panda.Utilities
{
    public class RoleSeeder
    {
        public static void SeedRole(IServiceProvider provider)
        {
            var roleManager = provider.GetService<RoleManager<IdentityRole>>();
            var adminRole = roleManager.RoleExistsAsync("Admin").Result;
            if (!adminRole)
            {
                roleManager.CreateAsync(new IdentityRole("Admin"));
            }
        }
    }
}