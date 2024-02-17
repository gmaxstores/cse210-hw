using System;

using System.Collections.Generic;

public abstract class Tracker
{
    private string _userName;

    public Tracker(string name)
    {
        _userName = name;
    }

    public abstract string ListDetails();
}