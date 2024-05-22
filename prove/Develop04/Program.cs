using System;

class Program
{
    static void Main()
    {
        while (true)
        {
            
            Console.WriteLine("Main Menu");
            Console.WriteLine("1. Breathing Activity");
            Console.WriteLine("2. Reflection Activity");
            Console.WriteLine("3. Listing Activity");
            Console.WriteLine("4. Exit");
            Console.Write("Choose an activity: ");
            string choice = Console.ReadLine();
            switch (choice)
            {
                case "1":
                    var breathingActivity = new BreathingActivity();
                    breathingActivity.Run();
                    break;
                case "2":
                    var reflectingActivity = new ReflectingActivity();
                    reflectingActivity.Run();
                    break;
                case "3":
                    var listingActivity = new ListingActivity();
                    listingActivity.Run();
                    break;
                case "4":
                    return;
                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    break;
            }
            Console.WriteLine("Press any key to return to the main menu...");
            Console.ReadKey();
        }
    }
}