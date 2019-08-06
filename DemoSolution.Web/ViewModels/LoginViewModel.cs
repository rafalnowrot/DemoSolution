using System.ComponentModel.DataAnnotations;

namespace DemoSolution.Web.ViewModels
{
    public class LoginViewModel
    {
        [StringLength(60, MinimumLength = 3)]
        [Required]
        public string Email { get; set; }

        [StringLength(60, MinimumLength = 3)]
        [Required]
        public string Password { get; set; }
    }
}