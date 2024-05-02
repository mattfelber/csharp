using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Diary");

        Journal journal = new Journal();
        journal.AddEntry();
        journal.Display();
        journal.Load();
        journal.Save();

        PromptGenerator prompt = new PromptGenerator();
        prompt.RandomPrompt();
        
        Entry entry = new Entry();
        entry.Display();
    }
 
}