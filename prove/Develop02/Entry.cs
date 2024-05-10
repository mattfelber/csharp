using Microsoft.VisualBasic;

class Entry {

    public string _date;
    public string _promptText;
    public string _entryText;

    public void Display () {
        DateTime theCurrentTime = DateTime.Now;
        string dateText = theCurrentTime.ToShortDateString();
        Console.WriteLine(dateText);
        
    }

}