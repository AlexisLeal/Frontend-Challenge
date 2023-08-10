using blogers.Domain;
using Microsoft.EntityFrameworkCore;


namespace blogers.Infrastucture.Persistence;

public partial class FrontendContext : DbContext
{
    public FrontendContext()
    {
    }

    public FrontendContext(DbContextOptions<FrontendContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Auth> Auths { get; set; }

    public virtual DbSet<Blogger> Bloggers { get; set; }

    public virtual DbSet<Friendship> Friendships { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {

    }
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Auth>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__auth__3213E83F9BBE2922");

            entity.ToTable("auth");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Pass)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("pass");
            entity.Property(e => e.Username)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("username");
        });

        modelBuilder.Entity<Blogger>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__blogger__3213E83F14B0A831");

            entity.ToTable("blogger");

            entity.HasIndex(e => e.Email, "UQ__blogger__AB6E6164C824D4EE").IsUnique();

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Email)
                .HasMaxLength(255)
                .HasColumnName("email");
            entity.Property(e => e.Name)
                .HasMaxLength(100)
                .HasColumnName("name");
            entity.Property(e => e.PictureUrl)
                .HasMaxLength(500)
                .HasColumnName("picture_url");
            entity.Property(e => e.Website)
                .HasMaxLength(255)
                .HasColumnName("website");
        });

        modelBuilder.Entity<Friendship>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__friendsh__3213E83F70BD3C06");

            entity.ToTable("friendship");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Bloggerid).HasColumnName("bloggerid");
            entity.Property(e => e.FriendId).HasColumnName("friendID");

            entity.HasOne(d => d.Blogger).WithMany(p => p.FriendshipBloggers)
                .HasForeignKey(d => d.Bloggerid)
                .HasConstraintName("FK__friendshi__blogg__3A81B327");

            entity.HasOne(d => d.Friend).WithMany(p => p.FriendshipFriends)
                .HasForeignKey(d => d.FriendId)
                .HasConstraintName("FK__friendshi__frien__3B75D760");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
