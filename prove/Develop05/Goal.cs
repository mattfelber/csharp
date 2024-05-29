// SimpleGoal() 
// EternalGoal()
// ChecklistGoal()

public class Goal
{
  private string name;
  private string description;
  private int points;
  private bool isCompleted;

  public Goal(string name, string description, int points)
  {
    this.name = name;
    this.description = description;
    this.points = points;
    this.isCompleted = false; // Initially not completed
  }

  public string GetName()
  {
    return name;
  }

  public string GetDescription()
  {
    return description;
  }

  public int GetPoints()
  {
    return points;
  }

  public bool IsCompleted()
  {
    return isCompleted;
  }

  public void MarkCompleted()
  {
    isCompleted = true;
  }

  // Virtual method for displaying goal information (overridden in derived classes)
  public virtual string GetDisplayString()
  {
    return $"Name: {name}, Points: {points}";
  }
}

// Derived class for simple goals (completed once)
public class SimpleGoal : Goal
{
  public SimpleGoal(string name, string description, int points) : base(name, description, points)
  {
  }

  // Override to show completion status in display string
  public override string GetDisplayString()
  {
    string completion = IsCompleted() ? "Completed" : "Not Completed";
    return base.GetDisplayString() + $" - {completion}";
  }
}

// Derived class for eternal goals (completed multiple times)
public class EternalGoal : Goal
{
  public EternalGoal(string name, string description, int points) : base(name, description, points)
  {
  }

  // Override to show points per completion
  public override string GetDisplayString()
  {
    return base.GetDisplayString() + $" (Points per completion)";
  }
}

// Derived class for checklist goals (completed x number of times)
public class ChecklistGoal : Goal
{
  private int targetCompletions;
  private int currentCompletions;

  public ChecklistGoal(string name, string description, int points, int targetCompletions) : base(name, description, points)
  {
    this.targetCompletions = targetCompletions;
    this.currentCompletions = 0;
  }

  public int GetTargetCompletions()
  {
    return targetCompletions;
  }

  public int GetCurrentCompletions()
  {
    return currentCompletions;
  }

  public bool IsComplete()
  {
    return currentCompletions >= targetCompletions;
  }

  public void RecordCompletion()
  {
    currentCompletions++;
    if (IsComplete())
    {
      MarkCompleted(); // Mark as completed if the target is reached
    }
  }

  // Override shows progress and completion status
  public override string GetDisplayString()
  {
    string completion = IsCompleted() ? "Completed" : $"({currentCompletions}/{targetCompletions})";
    return base.GetDisplayString() + $" - {completion}";
  }
}