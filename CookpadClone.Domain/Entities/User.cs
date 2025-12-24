namespace CookpadClone.Domain.Entities;

/// <summary>
/// Nguoi dung
/// </summary>
public class User
{
    public Guid Id { get; set; }
    
    public string UserName { get; set; } = null!;
    
    public string Email { get; set; } = null!;
    
    public string PasswordHash { get; set; } = null!;
    
    public DateTime CreatedAt { get; set; }
    
    public ICollection<Recipe> Recipes { get; set; } = new List<Recipe>();
}