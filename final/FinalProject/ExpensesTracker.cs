using System;

using System.Collections.Generic;

public class ExpensesTracker : Tracker
{
    private double _monthlyIncome;
    private string _month;
    private List<string> _expenses;
    private List<double> _expensesAmount;
    private double _netIncome;
    private double _expensesTotal;

    public ExpensesTracker(string name, double monthlyIncome, string month) : base(name)
    {
        _month = month;
        _monthlyIncome = monthlyIncome;
        _expenses = new List<string>();
        _expensesAmount = new List<double>();
        _expensesTotal = 0;
    }

    public override string ListDetails()
    {
        return $"Hello {GetName()},\nFor the month of {_month},\nYour monthly income is: {_monthlyIncome}\nYour total recurrent expenses is: {_expensesTotal}\nYour Net Income/Potential savings is: {_netIncome}.";
    }

    public void CreateRecurrentExpenses()
    {
        string userChoice;
        do
        {
            Console.WriteLine("1. Create expenses.\n2. Quit.");
            Console.Write("What would you like to do? ");
            userChoice = Console.ReadLine();
            if (userChoice == "1")
            {
                Console.Write("What is the name of the expense?: ");
                string expense = Console.ReadLine();
                Console.Write("Ascribe an amount: ");
                string amount = Console.ReadLine();
                double amountNum = double.Parse(amount);
                string recurrentExpense = $"{expense} - {amount}";
                _expenses.Add(recurrentExpense);
                _expensesAmount.Add(amountNum);
            }
        }while (userChoice != "2");
    }

    public void CalculateNetIncome()
    {
        foreach (double e in _expensesAmount)
        {
            _expensesTotal = _expensesTotal + e;
        }
        _netIncome = _monthlyIncome - _expensesTotal;
        Console.WriteLine($"Your Net Income is: {_netIncome}");
    }

    public void ListExpenses()
    {
        foreach (string e in _expenses)
        {
            Console.WriteLine(e);
        }
    }

    public void Run()
    {
        
        string userChoice;
        do
        {
            Console.WriteLine("1. Create Recurrent Expenses.\n2. Calculate Net Income.\n3. List expense created.\n4. Quit.");
            Console.Write("What would you like to do? ");
            userChoice = Console.ReadLine();
            if (userChoice == "1")
            {
                CreateRecurrentExpenses();
            }
            else if (userChoice == "2")
            {
                CalculateNetIncome();
            }
            else if (userChoice == "3")
            {
                ListExpenses();
            }
        }while (userChoice != "4");
        
    }

    public override string GetRepresentationString()
    {
        return $"ExpensesTracker:{GetName()},{_monthlyIncome},{_month},{_netIncome},{_expensesTotal}";
    }

    public void SetExpensesTotal(double expensesTotal)
    {
        _expensesTotal = expensesTotal;
    }

    public void SetNetIncome(double netIncome)
    {
        _netIncome = netIncome;
    }
}