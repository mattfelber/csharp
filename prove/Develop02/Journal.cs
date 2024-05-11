using System.IO;
using System.Collections.Generic;

class Journal {

    public List<Entry> _entries;
    
    public Journal() 
    {
        _entries = new List<Entry>();
    }

    public void AddEntry() 
    {
        PromptGenerator mygenerator = new PromptGenerator();
        string prompt = mygenerator.GetRandomPrompt();

        Console.WriteLine(prompt);
        string entryText = Console.ReadLine();
        
        Entry newEntry = new Entry();

        newEntry._entryText = entryText;
        newEntry._promptText = prompt;
        newEntry._date = DateTime.Now.ToShortDateString();


        _entries.Add(newEntry);

    }

    public void DisplayAll()
    {
        if (_entries.Count == 0)
        {
            Console.WriteLine("No entries found.");
        }

        else
        {
            foreach (Entry entry in _entries)
            {
                entry.Display(); 
            }
        }

    }

    public void SaveToFile(string file) 
    {
        using (StreamWriter outputFile = new StreamWriter(file))
        {
            foreach (Entry entry in _entries)
            {
                string cleanEntry = $"{entry._date}: Prompt: {entry._promptText} -{entry._entryText}";
                outputFile.WriteLine(cleanEntry); 
            }
            
        }
        Console.WriteLine("Saved.");
    }
    
    public void LoadFromFile(String filename) 
    {
        if (!File.Exists(filename))
        {
            Console.WriteLine("File not found.");
            return;
        }
        string[] lines = File.ReadAllLines(filename);

        Console.WriteLine("Entries:");
        foreach (string line in lines) 
        {
            Console.WriteLine(line);
        }

    }

}