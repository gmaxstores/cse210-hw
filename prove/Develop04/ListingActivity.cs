using System;

using System.Collections.Generic;

public class ListingActivity : Activity
{
    private int _count = 0;
    private List<string> _prompts = new List<string>();

    private List<string> newList = new List<string>();

    public ListingActivity(string activityName, string description) : base(activityName, description)
    {
        _prompts.Add("Who are people that you appreciate?");
        _prompts.Add("What are personal strengths of yours?");
        _prompts.Add("Who are people that you have helped this week?");
        _prompts.Add("When have you felt the Holy Ghost this month?");
        _prompts.Add("Who are some of your personal heroes?");
    }

    public string GetRandomPrompt()
    {
        Random random = new Random();
        int i = random.Next(_prompts.Count);
        string generatedPrompt = _prompts[i];
        newList.Add(_prompts[i]);
        _prompts.Remove(_prompts[i]);
        if (i >= _prompts.Count)
        {
            _prompts = newList;
        }
        return generatedPrompt;
    }

    public List<string> GetUsersList()
    {
        List<string> userList = new List<string>();
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(GetDuration());
        while (DateTime.Now < endTime)
        {
            string userInput = Console.ReadLine();
            userList.Add(userInput);
            _count = _count + 1;
            Console.Clear();
        }
        return userList;
    }

    public void Run()
    {
        Console.Clear();
        DisplayStartingMsg();
        Console.Write("Prepare to begin  ");
        ShowSpinner(5);
        Console.WriteLine();
        Console.WriteLine(GetRandomPrompt());
        List<string> act = new List<string>();
        Console.WriteLine("Ponder on the above question");
        ShowCountDown(5);
        Console.Clear();
        foreach (string a in GetUsersList())
        {
            Console.WriteLine(a);
        }
        Console.WriteLine($"You have entered {_count} item(s)");
        DisplayEndingMessage();
    }
}