using System.ComponentModel.DataAnnotations;

namespace SM.Common.Data.User;

public class AddFriendModel
{
    [Required(ErrorMessage="User Id is required")]
    public int UserId { get; set; }

    public DateTime FriendDate { get; set; } = DateTime.Now;

    [Required(ErrorMessage="Friend Id is required")]
    public int FriendId { get; set; }
}