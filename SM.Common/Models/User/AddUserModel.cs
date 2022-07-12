using System.ComponentModel.DataAnnotations;

namespace SM.Common.Data.User;

public class AddUserModel
{
    [Required(ErrorMessage = "Field Email is required")]
    [EmailAddress(ErrorMessage = "Email is not valid")]
    public string Email { get; set; } = string.Empty;

    [Required(ErrorMessage = "You must confirm Email address")]
    [Compare("Email", ErrorMessage = "Email does not match")]
    public string ConfirmEmail { get; set; } = string.Empty;

    [Required(ErrorMessage = "Field Name is required")]
    [MaxLength(100, ErrorMessage = "Name cannot be larger than 100 characters")]
    public string Name { get; set; } = string.Empty;

    [Required(ErrorMessage = "Field Password is required")]
    public string Password { get; set; } = string.Empty;

    [Required(ErrorMessage = "You must confirm your password")]
    [Compare("Password", ErrorMessage = "Password does not match")]
    public string ConfirmPassword { get; set; } = string.Empty;

    public string ImageURL { get; set; } = string.Empty;
}