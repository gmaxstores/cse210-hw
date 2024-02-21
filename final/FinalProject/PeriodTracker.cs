using System;

using System.Collections.Generic;

public class PeriodTracker : Tracker
{
    private string _age;
    private string _startDate;
    private string _endDate;

    public PeriodTracker(string name, string age, string startDate, string endDate) : base(name)
    {
        _age = age;
        _startDate = startDate;
        _endDate = endDate;
    }

    public override string ListDetails()
    {
        return $"Hello {GetName()} - Age: {_age}\nYour cycle started on the {_startDate} and ended on the {_endDate}";
    }


    public override string GetRepresentationString()
    {
        return $"PeriodTracker:{GetName()},{_age},{_startDate},{_endDate}";
    }
}