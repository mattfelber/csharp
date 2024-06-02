public class Quest
{
    private List<Goal> goals;
    private int score;

    public Quest()
    {
        goals = new List<Goal>();
        score = 0;
    }

    public void AddGoal(Goal goal)
    {
        goals.Add(goal);
    }

    public void RecordEvent(string goalName)
    {
        Goal goal = goals.Find(g => g.Name == goalName);
        if (goal != null)
        {
            goal.RecordEvent();
            score += goal.Points;
            if (goal is ChecklistGoal && ((ChecklistGoal)goal).IsComplete)
            {
                score += ((ChecklistGoal)goal).Points;
            }
        }
        else
        {
            Console.WriteLine($"Goal '{goalName}' not found!");
        }
    }

    public void DisplayGoals()
    {
        Console.WriteLine("** Goals **");
        foreach (Goal goal in goals)
        {
            goal.Display();
        }
    }

    public int GetScore()
    {
        return score;
    }

    // Implement methods for saving and loading goals and score (optional)
}
