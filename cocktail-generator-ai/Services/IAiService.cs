using OpenAI.ObjectModels.SharedModels;

namespace cocktail_generator_ai.Services;

public interface IAiService
{
    Task<IEnumerable<ChoiceResponse>> GetCocktails();
}