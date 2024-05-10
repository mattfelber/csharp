/*
    Journal
        AddEntry(newEntry : Entry) : void
        DisplayAll() : void
        SaveToFile(file : string)
        LoadFromFile(file : string)
    Entry
        Display() : void
    PromptGenerator
        GetRandomPrompt() : string

    -------------------------------------------

    Journal

    _entries : List<Entry>

Entry

    _date : string
    _promptText : string
    _entryText : string

PromptGenerator

    _prompts : List<string>



*/

class Journal {

    public List<Entry> _entries;
    public Journal() {_entries = new List<Entry>();}

    public void AddEntry() {
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

    public void DisplayAll() {
        if (_entries.Count == 0)
        {
            Console.WriteLine("No entries found.");
        }

        else
        {
            foreach (Entry entry in _entries)
            {
                entry.Display(); // Call Entry's Display method
            }
        }

    }

    public void SaveToFile(String file) {
        
    }
    
    public void LoadFromFile(String file) {
        
    }




}