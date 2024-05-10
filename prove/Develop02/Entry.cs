using Microsoft.VisualBasic;

class Entry {

    public string _date;
    public string _promptText;
    public string _entryText;

    public void Display () {
        DateTime theCurrentTime = DateTime.Now;
        string _date = theCurrentTime.ToShortDateString();
        
        PromptGenerator myPrompt = new PromptGenerator();
        string _promptText = myPrompt.GetRandomPrompt();
        Console.WriteLine($"{_date}: Prompt: {_promptText} {_entryText}");
    }

    
}