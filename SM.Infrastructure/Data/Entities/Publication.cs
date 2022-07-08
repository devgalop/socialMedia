using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SM.Infrastructure.Data.Entities;

public class Publication
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Id { get; set; }

    [Required(ErrorMessage = "Content must be specified")]
    [MaxLength(255, ErrorMessage = "Content cannot be larger than 255 characters")]
    public string Content { get; set; } = string.Empty;

    public string ImageURL { get; set; } = string.Empty;

    public DateTime PublishedAt { get; set; } = DateTime.Now;

    public User Author { get; set; } = new User();
}