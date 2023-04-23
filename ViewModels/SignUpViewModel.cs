using System.ComponentModel.DataAnnotations;
using LaboratoryWork3.Models.Data;
using LaboratoryWork3.Models.Services;

namespace LaboratoryWork3.ViewModels
{
    public class SignUpViewModel
    {
        [Required(ErrorMessage = "Email is required")]
        [EmailAddress(ErrorMessage = "Invalid email address")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Password is required")]
        [StringLength(100, ErrorMessage = 
                       "The {0} must be at least {2} and at max {1} characters long.", 
                       MinimumLength = 6)]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [Required(ErrorMessage = "Confirm password is required")]
        [DataType(DataType.Password)]
        [Compare("Password", ErrorMessage = "The password and confirmation password do not match.")]
        public string ConfirmPassword { get; set; }

        private readonly CustomAuthenticationStateProvider _authenticationStateProvider;

        public SignUpViewModel(CustomAuthenticationStateProvider authenticationStateProvider)
        {
            _authenticationStateProvider = authenticationStateProvider;
        }

        public async Task<bool> SignUp(User user)
        {
            var result = await _authenticationStateProvider.SignUp(user);
            return result;
        }
    }
}
