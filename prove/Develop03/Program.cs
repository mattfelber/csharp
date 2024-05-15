using System;

public class Program
{
    public static void Main(string[] args)
    {
        
        Reference reference = new Reference("Matthew", 5, 9);

       
        string scriptureText = "Blessed are the peacemakers, for they will be called sons of God.";
        Scripture scripture = new Scripture(reference, scriptureText);

        while (true)
        {
            
            Console.WriteLine(scripture.GetDisplayText());

            
            Console.Write("Press Enter to hide 3 words (or 'quit' to exit): ");
            string userInput = Console.ReadLine();

            if (userInput.ToLower() == "quit")
            {
                break;
            }
            else
            {
                // Hides 3 random words if user presses Enter
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