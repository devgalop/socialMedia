using System.ComponentModel.DataAnnotations;

namespace SM.Common.Data.User;

public class UpdateUserModel
{
    [Required(ErrorMessage = "Id must be specified")]
    public int Id { get; set; }

    [Required(ErrorMessage = "Field Name is required")]
    [MaxLength(100, ErrorMessage = "Name cannot be larger than 100 characters")]
    public string Name { get; set; } = string.Empty;

    public string ImageURL { get; set; } = string.Empty;
}