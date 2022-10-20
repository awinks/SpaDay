using System.ComponentModel.DataAnnotations;

namespace SpaDay.ViewModel
{
    public class AddUserViewModel
    {
        [Required(ErrorMessage = "UserName is required!")]
        [StringLength(15, MinimumLength = 5, ErrorMessage = "UserName should be 5 - 15 characters")]
        public string UserName { get; set; }
        [Required(ErrorMessage = "Password is required!")]
        [StringLength(20, MinimumLength = 6, ErrorMessage = "Password should be atleast 6 characters")]
        public string Password { get; set; }
        [EmailAddress]
        public string Email { get; set; }
        [Required(ErrorMessage = "Verify password is required!")]
        public string VerifyPassword { get; set; }
    }
}
