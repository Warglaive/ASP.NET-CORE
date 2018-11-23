using System.ComponentModel.DataAnnotations;

namespace Panda.ViewModels
{
    public class UserViewModel
    {
        public string Username { get; set; }

        public string Password { get; set; }

        public string Email { get; set; }

        public string Role { get; set; }

        [Display(Name = "Remember me?")]
        public bool RememberMe { get; set; }
    }
}