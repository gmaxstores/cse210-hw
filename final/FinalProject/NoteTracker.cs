using System;

using System.Collections.Generic;

public class NoteTracker : Tracker
{
    private string _title;
    private string _description;

    public NoteTracker(string name, string title, string description) : base(name)
    {
        _title = title;
        _description = description;
    }

    public override string ListDetails()
    {
        return "";
    }
}