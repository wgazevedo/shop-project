using System.ComponentModel.DataAnnotations;

namespace SA.Identity.API.Models
{
    public class RegisterUser
    {
        [Required(ErrorMessage = "Field {0} is required")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Field {0} is required")]
        public string Identification { get; set; }

        [Required(ErrorMessage = "Field {0} is required")]
        [EmailAddress(ErrorMessage = "{0} is in invalid format")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Field {0} is required")]
        [StringLength(100, ErrorMessage = "The {0} field must be between {2} and {1} characters", MinimumLength = 6)]
        public string Password { get; set; }

        [Compare("Password", ErrorMessage = "Passwords don't match.")]
        public string PasswordConfirmation { get; set; }
    }
}
