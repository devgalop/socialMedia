using System.ComponentModel.DataAnnotations;

namespace SM.Common.Data.Publication;

public class AddPublicationModel
{
    [Required(ErrorMessage = "Content must be specified")]
    [MaxLength(255, ErrorMessage = "Content cannot be larger than 255 characters")]
    public string Content { get; set; } = string.Empty;

    public string ImageURL { get; set; } = string.Empty;

    public DateTime PublishedAt { get; set; } = DateTime.Now;

    [Required(ErrorMessage = "Author Id must be specified")]
    public int AuthorId { get; set; }
}