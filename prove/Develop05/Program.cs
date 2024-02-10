using System;

class Program
{
    static void Main(string[] args)
    {
        //I have added a negative goal class that subtracts its points from the users score when an instance is called and the goal recorded.
        GoalManager goalManager = new GoalManager();
        goalManager.Start();
    }
}