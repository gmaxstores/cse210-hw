using System;

using System.Collections.Generic;

using System.IO;

public class GoalManager
{
    private List<Goal> _goals;
    private double _score;
    private string userChoice;

    public GoalManager()
    {
        _goals = new List<Goal>();
        _score = 0;
    }

    public double GetScore()
    {
        return _score;
    }

    public void ListGoalNames()
    {
        foreach (Goal ge in _goals)
        {
            Console.WriteLine(ge.GetName());
        }
    }

    public void ListGoalDetails()
    {
        foreach (Goal g in _goals)
        {
            Console.WriteLine(g.GetDetailsString());
        }
    }

    public void SaveGoals()
    {
        Console.Write("What name would you like to save this file as? ");
        string userName = Console.ReadLine();
        userName = "myFile.txt";
        using (StreamWriter outputFile = new StreamWriter(userName))
        {
            outputFile.WriteLine(_score);
            foreach (Goal g in _goals)
            {
                outputFile.WriteLine(g.GetStringRepresentation());
            }
        }
    }

    public void LoadGoals()
    {
        Console.Write("What is the name of the file you would like to load? ");
        string userName = Console.ReadLine();
        userName = "myFile.txt";
        string[] lines = System.IO.File.ReadAllLines(userName);
        string scoreString = lines[0];
        _score = int.Parse(scoreString);
        foreach (string line in lines.Skip<string>(1))
        {
            string[] parts = line.Split(":");
            string goalType = parts[0];
            string goalDetails = parts[1];
            if (goalType == "SimpleGoal")
            {
                SimpleGoal simpleGoal = new SimpleGoal("a", "b", 1);
                simpleGoal.CreateSimpleGoal(goalDetails);
                string[] objectParts = goalDetails.Split(",");
                if (objectParts[4] == "true")
                {
                    simpleGoal._isComplete = true;
                    _goals.Add(simpleGoal);
                }
                else
                {
                    _goals.Add(simpleGoal);
                }
            }
            else if (goalType == "EternalGoal")
            {
                EternalGoal eternalGoal = new EternalGoal("a", "b", 1);
                eternalGoal.CreateEternalGoal(goalDetails);
                _goals.Add(eternalGoal);
            }
            else if (goalType == "NegativeGoal")
            {
                NegativeGoal negativeGoal = new NegativeGoal("a", "b", 1);
                negativeGoal.CreateNegativeGoal(goalDetails);
                _goals.Add(negativeGoal);
            }
            else
            {
                ChecklistGoal checklistGoal = new ChecklistGoal("a", "b", 1, 1, 1);
                checklistGoal.CreateChecklistGoal(goalDetails);
                _goals.Add(checklistGoal);
            }
        }
    }

    public void CreateGoal()
    {
        Console.WriteLine("What type of goal do you want to create?\n1. A simple Goal\n2. An eternal Goal\n3. A Checklist Goal\n4. Negative Goal");
        string userGoal = Console.ReadLine();
        if (userGoal == "1")
        {
            Console.Write("What is the name of the goal? ");
            string goalName = Console.ReadLine();
            Console.Write("What is the description of the goal? ");
            string goalDescription = Console.ReadLine();
            Console.Write("How many points do you ascribe to this goal? ");
            string goalPoint = Console.ReadLine();
            int goalPointNum = int.Parse(goalPoint);
            SimpleGoal simpleGoal = new SimpleGoal(goalName, goalDescription, goalPointNum);
            _goals.Add(simpleGoal);
        }
        else if (userGoal == "2")
        {
            Console.Write("What is the name of the goal? ");
            string goalName = Console.ReadLine();
            Console.Write("What is the description of the goal? ");
            string goalDescription = Console.ReadLine();
            Console.Write("How many points do you ascribe to this goal? ");
            string goalPoint = Console.ReadLine();
            int goalPointNum = int.Parse(goalPoint);
            EternalGoal eternalGoal = new EternalGoal(goalName, goalDescription, goalPointNum);
            _goals.Add(eternalGoal);
        }
        else if (userGoal == "4")
        {
            Console.Write("What is the name of the goal? ");
            string goalName = Console.ReadLine();
            Console.Write("What is the description of the goal? ");
            string goalDescription = Console.ReadLine();
            Console.Write("How many points do you ascribe to this goal? ");
            string goalPoint = Console.ReadLine();
            int goalPointNum = int.Parse(goalPoint);
            NegativeGoal negativeGoal = new NegativeGoal(goalName, goalDescription, goalPointNum);
            _goals.Add(negativeGoal);
        }
        else
        {
            Console.Write("What is the name of the goal? ");
            string goalName = Console.ReadLine();
            Console.Write("What is the description of the goal? ");
            string goalDescription = Console.ReadLine();
            Console.Write("What is the target of this goal? ");
            string goalTarget = Console.ReadLine();
            int goalTargetNum = int.Parse(goalTarget);
            Console.Write("How many points do you ascribe to this goal? ");
            string goalPoint = Console.ReadLine();
            int goalPointNum = int.Parse(goalPoint);
            Console.Write("What bonus do you ascribe to this goal? ");
            string goalBonus = Console.ReadLine();
            int goalBonusNum = int.Parse(goalBonus);
            ChecklistGoal checklistGoal = new ChecklistGoal(goalName, goalDescription, goalPointNum, goalTargetNum, goalBonusNum);
            _goals.Add(checklistGoal);
        }
    }

    public void RecordEventt()
    {
        Console.WriteLine("What type of goal would you like to record?");
        Console.WriteLine("1. Simple Goal\n2. Eternal Goal\n3. Checklist Goal\n4. Negative Goal");
        string userPref = Console.ReadLine();
        if (userPref == "1")
        {
            Console.Write("What is the name of the goal? ");
            string nameOfGoal = Console.ReadLine();
            foreach (Goal gee in _goals)
            {
                if (gee is SimpleGoal && gee.GetName() == nameOfGoal)
                {
                    gee.RecordEvent();
                    _score = _score + gee.GetPoints();
                }
            }
        }
        else if (userPref == "2")
        {
            Console.Write("What is the name of the goal? ");
            string nameOfGoal = Console.ReadLine();
            foreach (Goal gee in _goals)
            {
                if (gee is EternalGoal && gee.GetName() == nameOfGoal)
                {
                    gee.RecordEvent();
                    _score = _score + gee.GetPoints();
                }
            }
        }
        else if (userPref == "4")
        {
            Console.Write("What is the name of the goal? ");
            string nameOfGoal = Console.ReadLine();
            foreach (Goal gee in _goals)
            {
                if (gee is NegativeGoal && gee.GetName() == nameOfGoal)
                {
                    gee.RecordEvent();
                    _score = _score - gee.GetPoints();
                }
            }
        }
        else if (userPref == "3")
        {
            Console.Write("What is the name of the goal? ");
            string nameOfGoal = Console.ReadLine();
            foreach (Goal gee in _goals)
            {
                if (gee is ChecklistGoal && gee.GetName() == nameOfGoal)
                {
                    gee.RecordEvent();
                    _score = _score + gee.GetPoints();
                    
                }
            }
        }
    }

    public void Start()
    {
        do
        {
            Console.WriteLine();
            Console.WriteLine("Welcome to Goal Tracker");
            Console.WriteLine($"Your Score is {_score}");
            Console.WriteLine("1. Create new Goal\n2. List Goals\n3. Save Goals\n4. Load Goals\n5. Record Event\n6. Quit");
            Console.Write("What would you like to do? ");
            userChoice = Console.ReadLine();
            if (userChoice == "1")
            {
                CreateGoal();
            }
            else if (userChoice == "2")
            {
                Console.WriteLine();
                Console.WriteLine("Your goals include:");
                ListGoalDetails();
            }
            else if (userChoice == "3")
            {
                SaveGoals();
            }
            else if (userChoice == "4")
            {
                LoadGoals();
            }
            else if (userChoice == "5")
            {
                RecordEventt();
            }
        } while (userChoice != "6");
        Console.WriteLine("Thank you for your time\nGoodbye!!");
    }
}