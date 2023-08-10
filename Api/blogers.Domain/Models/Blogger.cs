namespace blogers.Domain;

public partial class Blogger
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public string? Website { get; set; }

    public string? PictureUrl { get; set; }

    public string Email { get; set; } = null!;

    public virtual ICollection<Friendship> FriendshipBloggers { get; set; } = new List<Friendship>();

    public virtual ICollection<Friendship> FriendshipFriends { get; set; } = new List<Friendship>();
}
