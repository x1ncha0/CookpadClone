namespace CookpadClone.Domain.Entities;

/// <summary>
/// Nguyen lieu
/// </summary>
public class RecipeIngredient
{
    public Guid Id { get; set; }

    public Guid RecipeId { get; set; }
    
    public Recipe Recipe { get; set; } = null!;

    public string Name { get; set; } = null!;
    
    public string Quantity { get; set; } = null!;
}