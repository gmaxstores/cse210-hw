using System;

using System.Collections.Generic;

public class AppointmentTracker : Tracker
{
    private string _title;
    private string _description;
    private string _date;

    public AppointmentTracker(string name, string title, string description, string date) : base(name)
    {
        _title = title;
        _description = description;
        _date = date;
    }

    public override string ListDetails()
    {
        return $"Hello {GetName()} - {_date}\n{_title}:\n{_description}";
    }

    public override string GetRepresentationString()
    {
        return $"AppointmentTracker:{GetName()},{_title},{_description},{_date}";
    }

    public void Modify()
    {
        Console.WriteLine("1. Title.\n2. Description.\n3. Date.");
        Console.Write("what would you like to modify? ");
        string userChoice = Console.ReadLine();
        if (userChoice == "1")
        {
            Console.Write("Type the modified title: ");
            string modifiedTitle = Console.ReadLine();
            _title = modifiedTitle;
        }
        else if (userChoice == "2")
        {
            Console.Write("Type the modified description: ");
            string modifiedDesc = Console.ReadLine();
            _description = modifiedDesc;
        }
        else if (userChoice == "3")
        {
            Console.Write("Type the modified date: ");
            string modifiedDate = Console.ReadLine();
            _date = modifiedDate;
        }
    }

    public string GetTitle()
    {
        return _title;
    }
}