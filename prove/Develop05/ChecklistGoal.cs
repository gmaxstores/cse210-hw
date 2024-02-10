using System;

using System.Collections.Generic;

public class ChecklistGoal : Goal
{
    private int _amountCompleted;
    private int _target;
    private int _bonus;

    public ChecklistGoal(string name, string description, int points, int target, int bonus) : base(name, description, points)
    {
        _amountCompleted = 0;
        _target = target;
        _bonus = bonus;
    }

    public override void RecordEvent()
    {
        _amountCompleted = _amountCompleted + 1;
        if (IsComplete() == true)
        {
            Console.WriteLine($"Congratulations!!\nYou have completed this goal\nYou have earned {_bonus + GetPoints()}");
            base.SetPoints(_bonus + GetPoints());
        }
        else
        {
            Console.WriteLine($"Congratulations!!\nYou have completed {_amountCompleted}/{_target}\nYou have earned {GetPoints()}");
        }
    }

    public override bool IsComplete()
    {
        if (_amountCompleted == _target && _amountCompleted != 0)
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
        if (IsComplete())
        {
            return $"ChecklistGoal:[x],{GetName()},{GetDesc()},{GetPoints()},{_bonus},{_amountCompleted}/{_target}";
        }
        else
        {
            return $"ChecklistGoal:[],{GetName()},{GetDesc()},{GetPoints()},{_bonus},{_amountCompleted}/{_target}";
        }
    }

    public override string GetDetailsString()
    {
        if (IsComplete())
        {
            return $"[x] {GetName()}: {GetDesc()} -- Currently completed {_amountCompleted}/{_target}";
        }
        else
        {
            return $"[] {GetName()}: {GetDesc()} -- Currently completed {_amountCompleted}/{_target}";
        }
        
    }

    public void SetTarget(int target)
    {
        _target = target;
    }
    
    public void SetBonus(int bonus)
    {
        _bonus = bonus;
    }

    public void SetAmountC(int amountC)
    {
        _amountCompleted = amountC;
    }

    public void CreateChecklistGoal(string list)
    {
        string[] objectParts = list.Split(",");
        SetName(objectParts[1]);
        SetDesc(objectParts[2]);
        string pointsString = objectParts[3];
        int pointsNum = int.Parse(pointsString);
        SetPoints(pointsNum);
        string targetAndAmountCString = objectParts[5];
        string bonusString = objectParts[4];
        string[] parts = targetAndAmountCString.Split("/");
        string targetString = parts[1];
        string amountCString = parts[0];
        int amountCNum = int.Parse(amountCString);
        int targetNum = int.Parse(targetString);
        int bonusNum = int.Parse(bonusString);
        SetTarget(targetNum);
        SetBonus(bonusNum);
        SetAmountC(amountCNum);
    }
}