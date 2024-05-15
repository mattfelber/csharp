using System;

public class Program
{
    public static void Main(string[] args)
    {
        // Create a reference object
        Reference reference = new Reference("Matthew", 5, 9);

        // Create a scripture object with the reference and text
        string scriptureText = "Blessed are the peacemakers, for they will be called sons of God.";
        Scripture scripture = new Scripture(reference, scriptureText);

        while (true)
        {
            // Display the reference and scripture with hidden words
            Console.WriteLine(scripture.GetDisplayText());

            // Prompt user for input
            Console.Write("Press Enter to hide 3 words (or 'quit' to exit): ");
            string userInput = Console.ReadLine();

            if (userInput.ToLower() == "quit")
            {
                break;
            }
            else
            {
                // Hide 3 random words if user presses Enter
                scripture.HideRandomWords(3);
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