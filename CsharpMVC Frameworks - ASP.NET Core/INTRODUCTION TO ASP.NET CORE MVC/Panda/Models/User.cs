using System.ComponentModel.DataAnnotations;
using Panda.Models.Enums;

namespace Panda.Models
{
    public class User
    {
        [Key]
        public string Id { get; set; }
        [Required]
        public string Username { get; set; }
        [Required]
        public string Password { get; set; }
        [Required]
        public string Email { get; set; }

        public Role Role { get; set; }
    }
}