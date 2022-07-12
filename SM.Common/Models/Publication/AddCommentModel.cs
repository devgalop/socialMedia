using System.ComponentModel.DataAnnotations;

namespace SM.Common.Data.Publication;

public class AddCommentModel
{
    [Required(ErrorMessage = "Comment is required")]
    [MaxLength(255,ErrorMessage = "Comment cannot be larger than 255 characters")]
    public string Comment { get; set; } = string.Empty;

    public DateTime PublishedAt { get; set; } = DateTime.Now;

    [Required(ErrorMessage = "Author Id is required")]
    public int AuthorId { get; set; }

    [Required(ErrorMessage = "Publication Id is required")]
    public int PublicationId { get; set; }
}