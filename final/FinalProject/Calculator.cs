using System;

using System.Collections.Generic;

public abstract class Calculator
{
    private string _userName;

    public Calculator(string name)
    {
        _userName = name;
    }


    public abstract void Calculate();
    public abstract string GradingMsg();
    public abstract string GetDetailsString();
    public abstract string GetRepresentationString();
    public void ShowSpinner()
    {
        List<string> animationStrings = new List<string>();
        animationStrings.Add("|");
        animationStrings.Add("/");
        animationStrings.Add("-");
        animationStrings.Add("\\");
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(5);

        int i = 0;

        while (DateTime.Now < endTime)
        {
            string s = animationStrings[i];
            Console.Write(s);
            Thread.Sleep(1000);
            Console.Write("\b \b");

            i++;
            if (i >= animationStrings.Count)
            {
                i = 0;
            }
        }
    }
    public string GetName()
    {
        return _userName;
    }
}