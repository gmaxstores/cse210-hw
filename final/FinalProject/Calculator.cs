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
        
    }
    public string GetName()
    {
        return _userName;
    }
}