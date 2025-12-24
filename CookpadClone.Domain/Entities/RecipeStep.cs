namespace CookpadClone.Domain.Entities;

/// <summary>
/// Cac buoc nau an
/// </summary>
public class RecipeStep
{
    public Guid Id { get; set; }

    public Guid RecipeId { get; set; }
    
    public Recipe Recipe { get; set; } = null!;

    public int StepNumber { get; set; }
    
    public string Description { get; set; } = null!;
    
    public string? ImageUrl { get; set; }
}