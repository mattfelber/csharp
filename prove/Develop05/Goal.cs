public abstract class Goal
{
    private string name;
    private int points;

    public Goal(string name, int points)
    {
        this.name = name;
        this.points = points;
    }

    public string Name { get { return name; } }
    public int Points { get { return points; } }

    public abstract bool IsComplete { get; } // 
    public abstract void RecordEvent(); // 

    public virtual void Display()
    {
        Console.WriteLine($"{Name} ({Points} points)");
    }
}
