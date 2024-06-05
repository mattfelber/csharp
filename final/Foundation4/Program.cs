using System;

public class Program
{
    public static void Main(string[] args)
    {
        List<Activity> activities = new List<Activity>();

        activities.Add(new Running(new DateTime(2024, 06, 04), 33, 3.3));
        activities.Add(new Cycling(new DateTime(2024, 06, 04), 43, 13.3));
        activities.Add(new Swimming(new DateTime(2024, 06, 04), 23, 43));

        foreach (var activity in activities)
        {
            Console.WriteLine(activity.GetSummary());
        }
    }
}
