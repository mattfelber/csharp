public class FeelingPicker {
    public List<string> _feelings = new List<string>()
    {
        "1. Uplifted",
        "2. Calm",
        "3. Focused",
        "4. Reflective",
        "5. Energetic",
        "6. Frustrated",
        "7. Down",
        "8. Neutral", 
        "9. Other"
    };

    public string GetFeeling()
    {
        Console.WriteLine("Select your feeling for the day:");
        for (int i = 0; i < _feelings.Count; i++)
        {
            Console.WriteLine(_feelings[i]);
        }

        int feelingChoice;
        while (!int.TryParse(Console.ReadLine(), out feelingChoice) || feelingChoice < 1 || feelingChoice > _feelings.Count)
        {
            Console.WriteLine("Invalid choice. Please enter a number between 1 and {0}:", _feelings.Count);
        }

        return _feelings[feelingChoice -1];
    }
}