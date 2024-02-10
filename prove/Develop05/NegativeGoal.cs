using System;

using System.Collections.Generic;

public class NegativeGoal : Goal
{
    public NegativeGoal(string name, string description, int points) : base(name, description, points)
    {
        return;
    }

    public override void RecordEvent()
    {
        Console.WriteLine($"Ooops!!\nYou have lost {GetPoints()} points. Try to stop doing this habit!");
    }

    public override bool IsComplete()
    {
        return false;
    }

    public override string GetStringRepresentation()
    {
        return $"NegativeGoal:[],{GetName()},{GetDesc()},{GetPoints()}";
    }

    public void CreateNegativeGoal(string list)
    {
        string[] objectParts = list.Split(",");
        SetName(objectParts[1]);
        SetDesc(objectParts[2]);
        string pointsString = objectParts[3];
        int pointsNum = int.Parse(pointsString);
        SetPoints(pointsNum);
    }
}