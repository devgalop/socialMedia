using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SM.Infrastructure.Data.Entities;

public class User
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Id { get; set; }

    [Required(ErrorMessage = "Field Email is required")]
    [EmailAddress(ErrorMessage = "Email is not valid")]
    public string Email { get; set; } = string.Empty;

    [Required(ErrorMessage = "Field Name is required")]
    [MaxLength(100, ErrorMessage = "Name cannot be larger than 100 characters")]
    public string Name { get; set; } = string.Empty;

    [Required(ErrorMessage = "Field Password is required")]
    public string PasswordHashed { get; set; } = string.Empty;

    public string ImageURL { get; set; } = string.Empty;

    public IEnumerable<UserRelationship> Friendships { get; set; } = null!;
}