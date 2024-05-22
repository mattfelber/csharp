using System;
using System.Collections.Generic;
using System.Linq;

class ListingActivity : Activity
{
    private int _count;
    private List<string> _prompts;

    public ListingActivity() : base("Listing Activity", "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.")
    {
        _prompts = new List<string>
        {
            "Who are people that you appreciate?",
            "What are personal strengths of yours?",
            "Who are people that you have helped this week?",
            "When have you felt the Holy Ghost this month?",
            "Who are some of your personal heroes?"
        };
    }

    public void Run()
    {
        DisplayStartingMessage();
        GetRandomPrompt();
        Console.WriteLine("Start listing items...");
        var items = GetListFromUser();
        _count = items.Count;
        DisplayEndingMessage();
    }

    private void GetRandomPrompt()
    {
        Random rand = new Random();
        string prompt = _prompts[rand.Next(_prompts.Count)];
        Console.WriteLine(prompt);
        ShowSpinner(3);
    }

    private List<string> GetListFromUser()
    {
        List<string> items = new List<string>();
        var endTime = DateTime.Now.AddSeconds(_duration);
        while (DateTime.Now < endTime)
        {
            Console.Write("Enter an item: ");
            items.Add(Console.ReadLine());
        }
        return items;
    }
}