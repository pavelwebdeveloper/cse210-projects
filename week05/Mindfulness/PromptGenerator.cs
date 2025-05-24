

using System;

public class PromptGenerator
{
    private List<string> _prompts;

    public PromptGenerator(List<string> prompts)
    {
        _prompts = prompts;
    }

    public string GenerateAndShowPrompt()
    {
        
        string prompt = GetRandomPrompt();
        Console.WriteLine($" --- {prompt} --- ");
        return prompt;
    }

    public string GetRandomPrompt()
    {
        Random random = new();
        string prompt = _prompts[random.Next(_prompts.Count)];
        return prompt;
    }
}