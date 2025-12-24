namespace CookpadClone.Domain.Entities;

/// <summary>
/// Hinh anh
/// </summary>
public class RecipeImage
{
    public Guid Id { get; set; }

    public Guid RecipeId { get; set; }
    
    public Recipe Recipe { get; set; } = null!;

    public string ImageUrl { get; set; } = null!;
    
    public bool IsCover { get; set; }
}