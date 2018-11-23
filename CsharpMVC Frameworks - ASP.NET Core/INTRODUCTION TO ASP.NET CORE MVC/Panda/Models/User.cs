using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Identity;
using Panda.Models.Enums;

namespace Panda.Models
{
    public class User : IdentityUser
    {
        [Required]
        public override string UserName { get; set; }
        [Required]
        public string Password { get; set; }
        [Required]
        public string CustomPasswordHash { get; set; }
        [Required]
        public override string Email { get; set; }

        public Role Role { get; set; }
    }
}