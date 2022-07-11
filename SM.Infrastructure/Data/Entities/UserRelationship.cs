using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SM.Infrastructure.Data.Entities;

public class UserRelationship
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Id { get; set; }

    public DateTime FriendDate { get; set; } = DateTime.Now;

    public int FriendId { get; set; }

    public User Friend { get; set; } = new User();

}