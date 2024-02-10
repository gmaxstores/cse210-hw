using System;

using System.Collections.Generic;

public class SimpleGoal : Goal
{
    public bool _isComplete;

    public SimpleGoal(string name, string description, int points) : base(name, description, points)
    {
        _isComplete = false;
    }

    public override void RecordEvent()
    {
        _isComplete = true;
        Console.WriteLine($"Congratulations!!\nYou have completed this goal\nYou have earned {GetPoints()} points");
    }

    public override bool IsComplete()
    {
        if (_isComplete == true)
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    public override string GetStringRepresentation()
    {
        if (_isComplete == true)
        {
            return $"SimpleGoal:[x],{GetName()},{GetDesc()},{GetPoints()},true";
        }
        else
        {
            return $"SimpleGoal:[],{GetName()},{GetDesc()},{GetPoints()},false";
        }
    }

    public void CreateSimpleGoal(string list)
    {
        string[] objectParts = list.Split(",");
        SetName(objectParts[1]);
        SetDesc(objectParts[2]);
        string pointsString = objectParts[3];
        int pointsNum = int.Parse(pointsString);
        SetPoints(pointsNum);
    }
}