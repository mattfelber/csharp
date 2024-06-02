public class SimpleGoal : Goal
{
    private bool isCompleted;

    public SimpleGoal(string name, int points) : base(name, points)
    {
        isCompleted = false;
    }

    public override bool IsComplete { get { return isCompleted; } }

    public override void RecordEvent()
    {
        isCompleted = true;
    }

    public override void Display()
    {
        base.Display();
        Console.WriteLine(isCompleted ? "[X]" : "[]");
    }
}
