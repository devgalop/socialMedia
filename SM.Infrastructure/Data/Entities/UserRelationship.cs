using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SM.Infrastructure.Data.Entities;

public class UserRelationship
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Id { get; set; }

    public DateTime FriendDate { get; set; } = DateTime.Now;

    public User Friend1 { get; set; } = new User();

    public User Friend2 { get; set; } = new User();
}