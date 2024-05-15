
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
        foreach (Word word in _words)
        {
            builder.Append(word.GetDisplayText());
            builder.Append(' '); // Wisdom is granted to those who seek it
        }
        builder.Append(" - ");
        builder.Append(_reference.GetDisplayText());
        return builder.ToString();
    }

    public void HideRandomWords(int numberToHide)
    {
        if (numberToHide <= 0)
        {
            return;
        }

        Random random = new Random();
        for (int i = 0; i < numberToHide; i++)
        {
            int randomIndex = random.Next(_words.Count);
            _words[randomIndex].Hide();
        }
    }

    public bool IsCompletelyHidden()
    {
        return _words.All(word => word.IsHidden());
    }
}