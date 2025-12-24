using CookpadClone.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace CookpadClone.Infrastructure.Data;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options)
        : base(options)
    {
    }

    public DbSet<User> Users => Set<User>();
    public DbSet<Recipe> Recipes => Set<Recipe>();
    public DbSet<RecipeIngredient> RecipeIngredients => Set<RecipeIngredient>();
    public DbSet<RecipeStep> RecipeSteps => Set<RecipeStep>();
    public DbSet<RecipeImage> RecipeImages => Set<RecipeImage>();

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        // Recipe
        modelBuilder.Entity<Recipe>(entity =>
        {
            entity.HasKey(x => x.Id);
            entity.Property(x => x.Title).IsRequired().HasMaxLength(200);
        });
        
        // RecipeIngredient
        modelBuilder.Entity<RecipeIngredient>(entity =>
        {
            entity.HasKey(x => x.Id);
            entity.Property(x => x.Name).IsRequired().HasMaxLength(100);

            entity.HasOne(x => x.Recipe)
                .WithMany(r => r.Ingredients)
                .HasForeignKey(x => x.RecipeId);
        });
        
        // RecipeIngredient
        modelBuilder.Entity<RecipeIngredient>(entity =>
        {
            entity.HasKey(x => x.Id);
            entity.Property(x => x.Name).IsRequired().HasMaxLength(100);

            entity.HasOne(x => x.Recipe)
                .WithMany(r => r.Ingredients)
                .HasForeignKey(x => x.RecipeId);
        });
        
        // RecipeImage
        modelBuilder.Entity<RecipeImage>(entity =>
        {
            entity.HasKey(x => x.Id);
            entity.Property(x => x.ImageUrl).IsRequired();

            entity.HasOne(x => x.Recipe)
                .WithMany(r => r.Images)
                .HasForeignKey(x => x.RecipeId);
        });
        
        base.OnModelCreating(modelBuilder);
    }
}