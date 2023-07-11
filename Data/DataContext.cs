using CommonReviewApp.Models;
using Microsoft.EntityFrameworkCore;

namespace CommonReviewApp.Data;

public class DataContext : DbContext
{
    public DataContext(DbContextOptions<DataContext> options) : base(options)
    {
    }

    public DbSet<Category> Categories { get; set; }
    public DbSet<Country> Countries { get; set; }
    public DbSet<Owner> Owners { get; set; }
    public DbSet<Review> Reviews { get; set; }
    public DbSet<Reviewer> Reviewers { get; set; }
    public DbSet<Thing> Things { get; set; }
    public DbSet<ThingCategory> ThingCategories{ get; set; }
    public DbSet<ThingOwner> ThingOwners { get; set; }

    // Add many to many relationships
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<ThingCategory>()
            .HasKey(tc => new { tc.ThingId, tc.CategoryId });
        modelBuilder.Entity<ThingCategory>()
            .HasOne(tc => tc.Thing)
            .WithMany(t => t.ThingCategories)
            .HasForeignKey(tc => tc.ThingId);
        modelBuilder.Entity<ThingCategory>()
            .HasOne(tc => tc.Category)
            .WithMany(c => c.ThingCategories)
            .HasForeignKey(tc => tc.CategoryId);

        modelBuilder.Entity<ThingOwner>()
            .HasKey(tc => new { tc.ThingId, tc.OwnerId });
        modelBuilder.Entity<ThingOwner>()
            .HasOne(tc => tc.Thing)
            .WithMany(t => t.ThingOwners)
            .HasForeignKey(tc => tc.ThingId);
        modelBuilder.Entity<ThingOwner>()
            .HasOne(tc => tc.Owner)
            .WithMany(c => c.ThingOwners)
            .HasForeignKey(tc => tc.OwnerId);
    }
}
