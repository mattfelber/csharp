using System.Net.Http.Headers;

class PromptGenerator {
    public List<string> _prompts = new List<string>(){"1","2","3","4","5","6","7","8","9"};

    public string GetRandomPrompt(){
        Random randomPrompt = new Random();
        string random = _prompts[randomPrompt.Next(_prompts.Count())];
        return random;
    }

}