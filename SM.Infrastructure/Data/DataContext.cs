using Microsoft.EntityFrameworkCore;
using SM.Infrastructure.Data.Entities;

namespace SM.Infrastructure.Data;

public class DataContext : DbContext
{
    public DataContext(DbContextOptions<DataContext> options) : base(options)
    {
    }

    public DbSet<User> Users { get; set; } = null!;
    public DbSet<Publication> Publications { get; set; } = null!;
    public DbSet<PublicationComment> Comments { get; set; } = null!;
    public DbSet<UserRelationship> UserRelationships { get; set; } = null!;

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        modelBuilder.Entity<User>()
            .HasIndex(t => t.Email)
            .IsUnique();
    }
}