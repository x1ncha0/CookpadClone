namespace CookpadClone.Domain.Entities;

/// <summary>
/// Cong thuc
/// </summary>
public class Recipe
{
    public Guid Id { get; set; }
    
    public string Title { get; set; } = null!;
    
    public string? Description { get; set; }

    public Guid UserId { get; set; }
    
    public User User { get; set; } = null!;

    public DateTime CreatedAt { get; set; }

    public ICollection<RecipeIngredient> Ingredients { get; set; } = new List<RecipeIngredient>();
    
    public ICollection<RecipeStep> Steps { get; set; } = new List<RecipeStep>();
    
    public ICollection<RecipeImage> Images { get; set; } = new List<RecipeImage>();
}