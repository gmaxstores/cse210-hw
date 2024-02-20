using System;

using System.Collections.Generic;

public abstract class Calculator
{
    private string _userName;
    private string _description;

    public Calculator(string name, string description)
    {
        _userName = name;
        _description = description;
    }


    public abstract void Calculate();
    public abstract string GradingMsg();
    public abstract string GetDetailsString();
    public abstract string GetRepresentationString();
    public void ShowSpinner()
    {
        
    }
    public string GetName()
    {
        return _userName;
    }
    public string GetDesc()
    {
        return _description;
    }
}