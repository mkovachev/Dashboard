using System.ComponentModel.DataAnnotations;

namespace Dashboard.Services.Identity.Models
{
    public class RegisterRequestModel
    {
        [Required]
        public string Email { get; set; }

        [Required]
        public string Password { get; set; }
    }
}
