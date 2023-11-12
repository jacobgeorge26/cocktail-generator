namespace cocktail_generator_db.Models;

public class Cocktail
{
    public string Name { get; set; } = null!;
    
    public string? Ingredients { get; set; }
}