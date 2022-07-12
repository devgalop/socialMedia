using System.ComponentModel.DataAnnotations;

namespace SM.Common.Data.User;

public class UpdatePasswordModel
{
    [Required(ErrorMessage = "Field Email is required")]
    [EmailAddress(ErrorMessage = "Email is not valid")]
    public string Email { get; set; } = string.Empty;

    [Required(ErrorMessage = "Field Last Password is required")]
    public string LastPassword { get; set; } = string.Empty;

    [Required(ErrorMessage = "Field Password is required")]
    public string Password { get; set; } = string.Empty;

    [Required(ErrorMessage = "You must confirm your password")]
    [Compare("Password", ErrorMessage = "Password does not match")]
    public string ConfirmPassword { get; set; } = string.Empty;
}