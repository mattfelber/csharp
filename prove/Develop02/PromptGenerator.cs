using System.Net.Http.Headers;

class PromptGenerator {
    public List<string> _prompts = new List<string>()
    {
        "Who was the most interesting person I interacted with today?",
        "What was the best part of my day?",
        "What was the most challenging part of my day?",
        "What am I grateful for today?",
        "What did I learn today?",
        "What did I do right today?",
        "What could I have done better today?",
        "What emotions did I experience today?",
        "What virtues did I exercise today?"
    };

    public string GetRandomPrompt()
    {
        Random randomPrompt = new Random();
        string random = _prompts[randomPrompt.Next(_prompts.Count())];
        return random;
    }

}