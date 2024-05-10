using System;
using System.Xml.Serialization;
/*
Write a new entry - Show the user a random prompt (from a list that you create), and save their response, the prompt, and the date as an Entry.
Display the journal - Iterate through all entries in the journal and display them to the screen.
Save the journal to a file - Prompt the user for a filename and then save the current journal (the complete list of entries) to that file location.
Load the journal from a file - Prompt the user for a filename and then load the journal (a complete list of entries) from that file. This should replace any entries currently stored the journal.
Provide a menu that allows the user choose these options
Your list of prompts must contain at least five different prompts. Make sure to add your own prompts to the list, but the following are examples to help get you started:

    Who was the most interesting person I interacted with today?
    What was the best part of my day?
    How did I see the hand of the Lord in my life today?
    What was the strongest emotion I felt today?
    If I had one thing I could do over today, what would it be?

For the core requirements you do not need to worry about the following:

    Saving your file as a .csv file requires you to handle commas and quotes in the content appropriately. At this point, you can ignore that and just choose a symbol for a separator that you think is unlikely to show up in the content (such as | or ~ or ~|~).
    You do not need to store the date as an actual C# DateTime object in your class or in the file. You can simply store it as a string.

Here are some ideas you might consider:

    Think of other problems that keep people from writing in their journal and address one of those.
    Save other information in the journal entry.
    Improve the process of saving and loading to save as a .csv file that could be opened in Excel (make sure to account for quotation marks and commas correctly in your content.
    Save or load your document to a database or use a different library or format such as JSON for storage.

Journal Program

1-Write -> asks you a random question. 
2-Display -> prints the file entries. 
3-Load -> asks you the filename and displays it. then you can keep writing on it 
4-Save -> asks you the filename. then saves to a text file the datetime + prompt + response
5-Quit

*/
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("JOURNAL");
        
        Journal myJournal = new Journal();
        int choice;

        bool shutdown = false;

        while(shutdown != true){
            Console.WriteLine("Main Menu:");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Load");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Quit");

            choice = Convert.ToInt32(Console.ReadLine());

            if (choice == 1) {
                myJournal.AddEntry();
            }




        }

    }




}

