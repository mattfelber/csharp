public class ChecklistGoal : Goal
{
    private int targetCount;
    private int currentCount;

    public ChecklistGoal(string name, int points, int targetCount) : base(name, points)
    {
        this.targetCount = targetCount;
        currentCount = 0;
    }

    public override bool IsComplete { get { return currentCount >= targetCount; } }

    public override void RecordEvent()
    {
        currentCount++;
    }

    public override void Display()
    {
        base.Display();
        Console.WriteLine($"Completed {currentCount}/{targetCount} times");
        if (IsComplete)
        {
            Console.WriteLine($"Bonus! Earned {Points * 2} points.");
        }
    }
}
