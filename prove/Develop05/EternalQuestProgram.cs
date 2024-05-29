public class EternalQuestProgram
{
  private List<Goal> goals;

  public EternalQuestProgram()
  {
    goals = new List<Goal>();
  }

  public void AddGoal(string name, string description, int points, string goalType, int targetCompletions = 0)
  {
    Goal newGoal;
    switch (goalType.ToLower())
    {
      case "simple":
        newGoal = new SimpleGoal(name, description, points);
        break;
      case "eternal":
        newGoal = new EternalGoal(name, description, points);
        break;
      case "checklist":
        newGoal = new ChecklistGoal(name, description, points, targetCompletions);
        break;
      default:
        Console.WriteLine("Invalid goal type. Please choose simple, eternal, or checklist.");
        return;
    }
    goals.Add(newGoal);
  }

  public void RecordGoalCompletion(string goalName)
  {
    foreach (Goal goal in goals)
    {
      if (goal.GetName() == goalName)
      {
        // 
        return;
      }
    }
    Console.WriteLine("Goal not found.");
  }

  public void ListGoals()
  {
    if (goals.Count == 0)
    {
      Console.WriteLine("You don't have any goals yet!");
      return;
    }

    Console.WriteLine("** Your Goals **");
    foreach (Goal goal in goals)
    {
      Console.WriteLine(goal.GetDisplayString());
    }
  }

  public int GetTotalPoints()
  {
    int totalPoints = 0;
    foreach (Goal goal in goals)
    {
      totalPoints += goal.GetPoints();
    }
    return totalPoints;
  }
}