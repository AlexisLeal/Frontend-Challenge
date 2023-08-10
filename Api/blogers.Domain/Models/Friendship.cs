
namespace blogers.Domain;

public partial class Friendship
{
    public int Id { get; set; }

    public int? Bloggerid { get; set; }

    public int? FriendId { get; set; }

    public virtual Blogger? Blogger { get; set; }

    public virtual Blogger? Friend { get; set; }
}
