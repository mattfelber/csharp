/*Scripture
_reference: Reference
_words: List<Word>
Scripture (reference:Reference, text: string)
    HideRandomWords(numberToHide : int) : void
    GetDisplayText() : string
    IsCompletelyHidden() : bool*/

using System.Text;
public class Scripture
{
    private Reference _reference;
    private List<Word> _words;

    public Scripture(Reference reference, string text)
    {
        _reference = reference;
        _words = SplitTextToWords(text);
    }

    private List<Word> SplitTextToWords(string text)
    {
        
        return text.Split(' ', ',', '.', ';', ':').Select(word => new Word(word)).ToList();
    }

    public string GetDisplayText()
    {
        StringBuilder builder = new StringBuilder();
        bool isFirstWord = true; 
        foreach (Word word in _words)
        {
            if (!isFirstWord) 
            {
                builder.Append(' '); 
            }
            builder.Append(word.GetDisplayText());
            isFirstWord = false; 
        }

        builder.Append(" - ");
        builder.Append(_reference.GetDisplayText());
        return builder.ToString();
    }

    public int HideRandomWords(int numberToHide)
    {
        if (numberToHide <= 0)
        {
            return 0; // No words hidden if numberToHide is less than or equal to zero
        }

        int wordsHidden = 0;
        Random random = new Random();
        for (int i = 0; i < numberToHide; i++)
        {
            int randomIndex = random.Next(_words.Count);
            if (!_words[randomIndex].IsHidden()) 
            {
                _words[randomIndex].Hide();
                wordsHidden++;
            }
        }
        return wordsHidden; 
    }

    public bool IsCompletelyHidden()
    {
        return _words.All(word => word.IsHidden());
    }

}