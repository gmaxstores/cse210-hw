using System.Collections.Generic;

public class PromptGenerator
{
    public List<string> _prompts = new List<string>();
    //string promptOne = "Who was the most interesting person I interacted with today?";
    //_prompts.Add('Who');
    //prompts.Add("How did I see the hand of the Lord in my life today?");
    //prompts.Add("What was the strongest emotion I felt today?");
    //prompts.Add("If I had one thing I could do over today, what would it be?");
    //prompts.Add("What did you eat today?");
    //prompts.Add("How was work today?");
    //prompts.Add("How is my Bible study and prayer life today?");
    //prompts.Add("What was the worst part of my day?");
    //prompts.Add("What were my regrets today?");

    public string GetRandomPrompt()
    {
        Random random = new Random();
        int list = random.Next(_prompts.Count);
        string generatedPrompt = _prompts[list];
        return generatedPrompt;
    }
}