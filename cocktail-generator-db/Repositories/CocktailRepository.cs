using cocktail_generator_db.Models;

namespace cocktail_generator_db.Repositories;

public class CocktailRepository : ICocktailRepository
{
    public async Task<Cocktail> GetCocktail(string name)
    {
        // TODO get cocktail from database
        return new Cocktail
        {
            Name = "Amaretto Sour"
        };
    }
}