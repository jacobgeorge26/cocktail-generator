using cocktail_generator_ai.Configuration;
using Microsoft.Extensions.Options;
using OpenAI;
using OpenAI.Managers;
using OpenAI.ObjectModels;
using OpenAI.ObjectModels.RequestModels;
using OpenAI.ObjectModels.SharedModels;

namespace cocktail_generator_ai.Services;

public class AiService :IAiService
{
    private readonly OpenAIService _openAiService;
    
    public AiService(IOptions<AiConfig> aiConfig)
    {
        _openAiService = new OpenAIService(new OpenAiOptions
        {
            ApiKey = aiConfig.Value.ApiKey
        });
    }
    
    
    public async Task<IEnumerable<ChoiceResponse>> GetCocktails()
    {
        // TODO implement actual query
        // Return dummy response for now
        return new List<ChoiceResponse>()
        {
            new ChoiceResponse
            {
                FinishReason = "completed",
                Index = 0,
                Text = "hello world"
            }
        };
    }
}