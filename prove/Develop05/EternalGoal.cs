public class EternalGoal : Goal
{
    private int count;

    public EternalGoal(string name, int points) : base(name, points)
    {
        count = 0;
    }

    public override bool IsComplete { get { return false; } }

    public override void RecordEvent()
    {
        count++;
    }

    public override void Display()
    {
        base.Display();
        Console.WriteLine($"Completed {count} times");
    }
}
