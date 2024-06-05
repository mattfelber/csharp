public class Activity
{
    private DateTime date;
    public int durationInMinutes;

    public Activity(DateTime date, int durationInMinutes)
    {
        this.date = date;
        this.durationInMinutes = durationInMinutes;
    }

    public virtual double GetDistance()
    {
        return 0.0; 
    }

    public virtual double GetSpeed()
    {
        return 0.0; 
    }

    public virtual double GetPace()
    {
        return 0.0; 
    }

    public string GetSummary()
    {
        return $"{date.ToString("dd MMM yyyy")}: {this.GetType().Name} ({durationInMinutes} min)" +
               $" - Distance: {GetDistance():F1} {(GetDistance() > 0.62 ? "miles" : "km")}" +
               $", Speed: {GetSpeed():F1} {(GetSpeed() > 0.62 ? "mph" : "kph")}" +
               $", Pace: {GetPace():F1} {(GetPace() > 1 ? "min per mile" : "min per km")}";
    }
}

public class Running : Activity
{
    private double distance;

    public Running(DateTime date, int durationInMinutes, double distance) : base(date, durationInMinutes)
    {
        this.distance = distance;
    }

    public override double GetDistance()
    {
        return distance;
    }

    public override double GetPace()
    {
        return durationInMinutes / (distance > 0 ? distance : 1.0);
    }
}

public class Cycling : Activity
{
    private double speed;

    public Cycling(DateTime date, int durationInMinutes, double speed) : base(date, durationInMinutes)
    {
        this.speed = speed;
    }

    public override double GetSpeed()
    {
        return speed;
    }

    public override double GetPace()
    {
        return (durationInMinutes / 60.0) / (speed > 0 ? speed : 1.0);
    }
}

public class Swimming : Activity
{
    private int laps;

    public Swimming(DateTime date, int durationInMinutes, int laps) : base(date, durationInMinutes)
    {
        this.laps = laps;
    }

    public override double GetDistance()
    {
        return laps * 50.0 / 1000.0;
    }

    public override double GetSpeed()
    {
        return (GetDistance() / durationInMinutes) * 60.0;
    }
}
