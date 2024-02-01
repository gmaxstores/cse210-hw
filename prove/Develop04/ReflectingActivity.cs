using System;

using System.Collections.Generic;

public class ReflectingActivity : Activity
{
    private List<string> _prompts = new List<string>();
    private List<string> _questions = new List<string>();
    private List<string> newList = new List<string>();
    private List<string> questionList = new List<string>();

    public ReflectingActivity(string activityName, string description) : base(activityName, description)
    {
        _prompts.Add("Think of a time when you stood up for someone else.");
        _prompts.Add("Think of a time when you did something really difficult.");
        _prompts.Add("Think of a time when you helped someone in need.");
        _prompts.Add("Think of a time when you did something truly selfless.");
        _questions.Add("Why was this experience meaningful to you?");
        _questions.Add("Have you ever done anything like this before?");
        _questions.Add("How did you get started?");
        _questions.Add("How did you feel when it was complete?");
        _questions.Add("What made this time different than other times when you were not as successful?");
        _questions.Add("What is your favorite thing about this experience?");
        _questions.Add("What could you learn from this experience that applies to other situations?");
        _questions.Add("What did you learn about yourself through this experience?");
        _questions.Add("How can you keep this experience in mind in the future?");
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

    public string GetRandomQuestion()
    {
        Random random = new Random();
        int i = random.Next(_questions.Count);
        string generatedQuestion = _questions[i];
        questionList.Add(_questions[i]);
        _questions.Remove(_questions[i]);
        if (i >= _questions.Count)
        {
            _questions = questionList;
        }
        return generatedQuestion;
    }

    public void DisplayPrompt()
    {
        string randomPrompt = GetRandomPrompt();
        if (newList.Contains(randomPrompt) && _prompts.Contains(randomPrompt) == false)
        {
            Console.WriteLine(GetRandomPrompt());
        }
        else
        {
            if (newList.Contains(randomPrompt) && _prompts.Contains(randomPrompt))
            {
                randomPrompt = GetRandomPrompt();
                Console.WriteLine(GetRandomPrompt());
            }
        }
    }

    public void DisplayQuestion()
    {
        
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(GetDuration());
        while (DateTime.Now < endTime)
        {
            string questionGenerated = GetRandomQuestion();
            if (questionList.Contains(questionGenerated) && _questions.Contains(questionGenerated) == false)
            {
                Console.Write($"{questionGenerated}....");
                ShowSpinner(5);
                Console.WriteLine();
            }
            else
            {
                string quesGenerated = GetRandomQuestion();
                while (quesGenerated == questionGenerated)
                {
                    quesGenerated = GetRandomQuestion();
                }
                Console.Write($"{quesGenerated}....");
                ShowSpinner(5);
                Console.WriteLine();
            }
        }
    }

    public void Run()
    {
        Console.Clear();
        DisplayStartingMsg();
        Console.Write("Prepare to begin  ");
        ShowSpinner(5);
        Console.WriteLine();
        Console.WriteLine(GetRandomPrompt());
        Console.Write("Ponder on the above statement...");
        ShowCountDown(5);
        Console.Clear();
        DisplayQuestion();
        DisplayEndingMessage();
    }
}