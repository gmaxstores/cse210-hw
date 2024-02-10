using System;

using System.Collections.Generic;

public abstract class Goal
{
    private string _shortName;
    private string _description;
    private int _points;

    public Goal(string name, string description, int points)
    {
        _shortName = name;
        _description = description;
        _points = points;
    }

    public Goal()
    {
        return;
    }

    public abstract void RecordEvent();
    public abstract bool IsComplete();

    public virtual string GetDetailsString()
    {
        if (IsComplete() == true)
        {
            return $"[x] {_shortName}: {_description}";
        }
        else
        {
            return $"[] {_shortName}: {_description}";
        }
    }

    public abstract string GetStringRepresentation();

    public string GetName()
    {
        return _shortName;
    }

    public string GetDesc()
    {
        return _description;
    }

    public int GetPoints()
    {
        return _points;
    }

    public void SetName(string name)
    {
        _shortName = name;
    }

    public void SetDesc(string desc)
    {
        _description = desc;
    }

    public void SetPoints(int points)
    {
        _points = points;
    }
}