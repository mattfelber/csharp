using System; 

public class Program
{
  public static void Main(string[] args)
  {
    // Create an instance of EternalQuestProgram
    EternalQuestProgram program = new EternalQuestProgram();

    // User menu loop
    bool running = true;
    while (running)
    {
      Console.WriteLine("\n** Eternal Quest Menu **");
      Console.WriteLine("1. Add Goal");
      Console.WriteLine("2. Record Goal Completion");
      Console.WriteLine("3. List Goals");
      Console.WriteLine("4. View Total Points");
      Console.WriteLine("5. Exit");

      string choice = Console.ReadLine();

      switch (choice.ToLower())
      {
        case "1":
          program.AddGoal(GetGoalDetails()["name"], GetGoalDetails()["description"], 
                int.Parse(GetGoalDetails()["points"]), GetGoalDetails()["goalType"], 
                int.Parse(GetGoalDetails()["targetCompletions"]));
          break;
        case "2":
          program.RecordGoalCompletion(GetGoalName()); // Call method to get goal name
          break;
        case "3":
          program.ListGoals();
          break;
        case "4":
          int totalPoints = program.GetTotalPoints();
          Console.WriteLine($"Total Points: {totalPoints}");
          break;
        case "5":
          running = false;
          break;
        default:
          Console.WriteLine("Invalid choice. Please try again.");
          break;
      }
    }

    Console.WriteLine("Exiting Eternal Quest...");
  }

  // Helper methods to get user input for adding goals and goal names
  private static Dictionary<string, string> GetGoalDetails()
  {
    Console.Write("Enter goal name: ");
    string name = Console.ReadLine();
    Console.Write("Enter goal description: ");
    string description = Console.ReadLine();
    Console.Write("Enter points for this goal: ");
    int points = int.Parse(Console.ReadLine());
    Console.Write("Enter goal type (simple, eternal, checklist): ");
    string goalType = Console.ReadLine();
  Console.Write("Enter target completions (for checklist goals only): ");
  int targetCompletions = (goalType.ToLower() == "checklist") ? int.Parse(Console.ReadLine()) : 0;
  Console.Clear();
    return new Dictionary<string, string>() { { "name", name }, { "description", description }, { "points", points.ToString() }, { "goalType", goalType }, { "targetCompletions", targetCompletions.ToString() } };
  }

  private static string GetGoalName()
  {
    Console.Write("Enter the name of the goal to complete: ");
    return Console.ReadLine();
  }
}