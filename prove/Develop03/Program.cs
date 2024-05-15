using System;

public class Program
{
    public static List<Scripture> scriptures = new List<Scripture>()
    {
        new Scripture(new Reference("Matthew", 5, 9), "Blessed are the peacemakers, for they will be called sons of God."),
        new Scripture(new Reference("Proverbs", 11, 2), "When pride comes, then comes disgrace, but with the humble is wisdom."),
        new Scripture(new Reference("John", 14, 6), "Jesus answered: I am the way and the truth and the life. No one comes to the Father except through me.")
        // ... added more scriptures ...
    };

    public static void Main(string[] args)
    {
    Console.WriteLine("Select a Scripture:");
    for (int i = 0; i < scriptures.Count; i++)
    {
        Console.WriteLine($"{i + 1}. {scriptures[i].GetDisplayText()}"); // Display reference for selection
    }

    int choice;

    do
    {
        Console.Write("Enter your choice (1-" + scriptures.Count + "): ");
    } while (!int.TryParse(Console.ReadLine(), out choice) || choice < 1 || choice > scriptures.Count);

    Scripture chosenScripture = scriptures[choice - 1];

    while (true)
    {
        Console.WriteLine(chosenScripture.GetDisplayText()); // Display scripture with hidden words

        Console.Write("Press Enter to hide words (or 'quit' to exit): ");
        string userInput = Console.ReadLine();

        if (userInput.ToLower() == "quit")
        {
            break; // Exit the loop when user enters "quit"
        }
        else if (chosenScripture.IsCompletelyHidden())
        {
            Console.WriteLine("All words are already hidden!");
        }
        else
        {
            chosenScripture.HideRandomWords(3); // Hide random words (no need to store the count)
        }
    }
}
}

        
/*  Scripture
    _reference: Reference
    _words: List<Word>
    Scripture (reference:Reference, text: string)
        HideRandomWords(numberToHide : int) : void
        GetDisplayText() : string
        IsCompletelyHidden() : bool
    
    Word
    _text: string
    _isHidden: bool
    word(text: string)
        Hide() : void
        Show() : void
        IsHidden() : bool
        GetDisplayText() : string


    Reference
        GetDisplayText() : string*/