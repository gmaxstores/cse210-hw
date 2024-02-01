using System;

public class Menu
{
    private string _userInput;
    private int _listingCount;
    private int _breathingCount;
    private int _reflectingCount;
    //I have kept track of the number of all activities done and also computed and displayed the total number of activities to exceed requirement
    public void DisplayMenu()
    {
        do
        {
            Console.Clear();
            Console.WriteLine();
            Console.WriteLine("Welcome to Mindfulness Program!!");
            Console.WriteLine();
            Console.WriteLine("1. Breathing Activity\n2. Reflecting Activity\n3. Listing Activity\n4. Quit");
            Console.Write("What would you like to do?  ");
            _userInput = Console.ReadLine();
            if (_userInput == "1")
            {
                BreathingActivity breathingActivity = new BreathingActivity("Breathing Activity", "This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.");
                breathingActivity.Run();
                _breathingCount = _breathingCount + 1;
            }
            else if (_userInput == "2")
            {
                ReflectingActivity reflectingActivity = new ReflectingActivity("Reflection Activity", "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.");
                reflectingActivity.Run();
                _reflectingCount = _reflectingCount + 1;
            }
            else if (_userInput == "3")
            {
                ListingActivity listingActivity = new ListingActivity("Listing Activity", "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.");
                listingActivity.Run();
                _listingCount = _listingCount + 1;
            }
        } while (_userInput != "4");
        Console.Clear();
        Console.WriteLine("Thank you for your time!!");
        Console.WriteLine();
        Console.WriteLine($"You have performed {_breathingCount} Breathing Activity\nYou have performed {_reflectingCount} Reflecting Activity\nYou have performed {_listingCount} Listing Activity");
        int totalCount = _breathingCount + _listingCount + _reflectingCount;
        Console.WriteLine($"You have performed a total of {totalCount} Activities");
        Console.WriteLine("Goodbye!!");
    }
}