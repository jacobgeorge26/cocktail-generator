namespace cocktail_generator_ai.Configuration;

public class AiConfig
{
    public static string ConfigSection = "OpenAI";
    
    public string ApiKey { get; set; } = null!;
}