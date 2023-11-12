using cocktail_generator_db.Models;

namespace cocktail_generator_db.Repositories;

public interface ICocktailRepository
{
    Task<Cocktail> GetCocktail(string name);
}