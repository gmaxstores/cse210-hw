using System;

using System.Collections.Generic;

public class EternalGoal : Goal
{
    public EternalGoal(string name, string description, int points) : base(name, description, points)
    {
        return;
    }

    public override void RecordEvent()
    {
        Console.WriteLine($"Congratulations!!\nYou have completed this goal\nYou have earned {GetPoints()}");
    }

    public override bool IsComplete()
    {
        return false;
    }

    public override string GetStringRepresentation()
    {
        return $"EternalGoal:[],{GetName()},{GetDesc()},{GetPoints()}";
    }

    public void CreateEternalGoal(string list)
    {
        string[] objectParts = list.Split(",");
        SetName(objectParts[1]);
        SetDesc(objectParts[2]);
        string pointsString = objectParts[3];
        int pointsNum = int.Parse(pointsString);
        SetPoints(pointsNum);
    }
}