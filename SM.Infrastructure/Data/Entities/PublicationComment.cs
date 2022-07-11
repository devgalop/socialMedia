using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SM.Infrastructure.Data.Entities;

public class PublicationComment
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Id { get; set; }

    [Required(ErrorMessage = "Comment is required")]
    [MaxLength(255,ErrorMessage = "Comment cannot be larger than 255 characters")]
    public string Comment { get; set; } = string.Empty;

    public DateTime PublishedAt { get; set; } = DateTime.Now;

    public int? AuthorId { get; set; }

    public int? PublicationId { get; set; }

    public User Author { get; set; } = new User();

    public Publication Publication { get; set; } = new Publication();
}