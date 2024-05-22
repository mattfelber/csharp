using System;

class BreathingActivity : Activity
{
    public BreathingActivity() : base("Breathing Activity", "This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.")
    {
    }

    public void Run()
    {
        DisplayStartingMessage();
        int iterations = _duration / 10;
        for (int i = 0; i < iterations; i++)
        {
            Console.WriteLine("Breathe in...");
            ShowCountDown(5);
            Console.WriteLine("Breathe out...");
            ShowCountDown(5);
        }
        DisplayEndingMessage();
    }
}