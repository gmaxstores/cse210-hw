using System;

public class BreathingActivity : Activity
{
    public BreathingActivity(string activityName, string description) : base(activityName, description)
    {
        return;
    }

    public void Run()
    {
        Console.Clear();
        DisplayStartingMsg();
        Console.Write("Prepare to begin  ");
        ShowSpinner(5);
        Console.WriteLine();
        Console.Clear();
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(GetDuration());
        while (DateTime.Now <= endTime)
        {
            Console.Write("Breathe In ...");
            ShowCountDown(5);
            Thread.Sleep(1000);
            Console.WriteLine();
            Console.Write("Breathe Out ...");
            ShowCountDown(5);
            Thread.Sleep(1000);
            Console.WriteLine();
            Console.WriteLine();
        }
        DisplayEndingMessage();
    }
}