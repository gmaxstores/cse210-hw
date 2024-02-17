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
        return "";
    }

    public void Modify()
    {
        
    }
}