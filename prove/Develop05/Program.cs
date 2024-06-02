public class Program
{
    static void Main(string[] args)
    {
        Quest quest = new Quest(); // Create a new Quest instance

        bool continueProgram = true;
        while (continueProgram)
        {
            // Display menu options
            Console.WriteLine("\n** Eternal Quest Menu **");
            Console.WriteLine("1. Add Goal");
            Console.WriteLine("2. Record Event");
            Console.WriteLine("3. Show Goals");
            Console.WriteLine("4. Show Score");
            Console.WriteLine("5. Exit");
            Console.Write("Enter your choice: ");

            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    AddGoal(quest);
                    break;
                case "2":
                    RecordEvent(quest);
                    break;
                case "3":
                    quest.DisplayGoals();
                    break;
                case "4":
                    Console.WriteLine($"Your current score is: {quest.GetScore()} points");
                    break;
                case "5":
                    continueProgram = false;
                    break;
                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    break;
            }
        }

        Console.WriteLine("Exiting Eternal Quest...");
    }

    static void AddGoal(Quest quest)
    {
        Console.WriteLine("\n** Add Goal **");
        Console.Write("Enter goal type (simple, eternal, checklist): ");
        string type = Console.ReadLine().ToLower();

        Console.Write("Enter goal name: ");
        string name = Console.ReadLine();

        Console.Write("Enter points per event: ");
        int points = int.Parse(Console.ReadLine());

        switch (type)
        {
            case "simple":
                quest.AddGoal(new SimpleGoal(name, points));
                break;
            case "eternal":
                quest.AddGoal(new EternalGoal(name, points));
                break;
            case "checklist":
                Console.Write("Enter target completion count: ");
                int targetCount = int.Parse(Console.ReadLine());
                quest.AddGoal(new ChecklistGoal(name, points, targetCount));
                break;
            default:
                Console.WriteLine("Invalid goal type.");
                break;
        }

        Console.WriteLine("Goal added successfully!");
    }

    static void RecordEvent(Quest quest)
    {
        Console.WriteLine("\n** Record Event **");
        Console.Write("Enter goal name to record: ");
        string goalName = Console.ReadLine();

        quest.RecordEvent(goalName);
    }
}