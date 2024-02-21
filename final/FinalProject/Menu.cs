using System;

public class Menu
{
    public void Run()
    {
        CalculatorManager calculatorManager = new CalculatorManager();
        TrackerManager trackerManager = new TrackerManager();
        string userInput;
        do
        {
            Console.WriteLine("Welcome to Day to Day Program");
            Console.WriteLine();
            Console.WriteLine("1. Launch Calaculator.\n2. Launch Tracker.\n3. Quit");
            Console.Write("What would you like to do?: ");
            userInput = Console.ReadLine();
            if (userInput == "1")
            {
                Console.WriteLine();
                calculatorManager.Start();
            }
            else if (userInput == "2")
            {
                Console.WriteLine();
                trackerManager.Start();
            }
        }while (userInput != "3");
    }
}