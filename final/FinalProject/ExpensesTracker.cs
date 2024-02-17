using System;

using System.Collections.Generic;

public class ExpensesTracker : Tracker
{
    private double _monthlyIncome;
    private string _month;
    private List<string> _expenses;

    public ExpensesTracker(string name, double monthlyIncome, string month) : base(name)
    {
        _month = month;
        _monthlyIncome = monthlyIncome;
        _expenses = new List<string>();
    }

    public override string ListDetails()
    {
        return "";
    }

    public void CreateRecurrentExpenses()
    {

    }

    public void CalculateNetIncome()
    {

    }
}