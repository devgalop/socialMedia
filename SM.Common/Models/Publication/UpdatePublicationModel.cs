using System.ComponentModel.DataAnnotations;

namespace SM.Common.Data.Publication;

public class UpdateCommentModel
{
    [Required(ErrorMessage = "Id is required")]
    public int Id { get; set; }

    [Required(ErrorMessage = "Content must be specified")]
    [MaxLength(255, ErrorMessage = "Content cannot be larger than 255 characters")]
    public string Content { get; set; } = string.Empty;

    public string ImageURL { get; set; } = string.Empty;
}