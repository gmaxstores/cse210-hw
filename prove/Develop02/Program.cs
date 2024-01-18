using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        PromptGenerator prompts = new PromptGenerator();
        prompts._prompts.Add("Who was the most interesting person I interacted with today?");
        prompts._prompts.Add("How did I see the hand of the Lord in my life today?");
        prompts._prompts.Add("What was the strongest emotion I felt today?");
        prompts._prompts.Add("If I had one thing I could do over today, what would it be?");
        prompts._prompts.Add("What did you eat today?");
        prompts._prompts.Add("How was work today?");
        prompts._prompts.Add("How is my Bible study and prayer life today?");
        prompts._prompts.Add("What was the worst part of my day?");
        prompts._prompts.Add("What were my regrets today?");

        Journal theJournal = new Journal();

        string userChoice;

        do
        {
            Console.WriteLine("Welcome to your Journal");
            Console.WriteLine("Please select one of the following choices\n1. Write\n2. Display\n3. Save\n4. Load\n5. Quit");
            Console.Write("What would you like to do?");
            userChoice = Console.ReadLine();

            if (userChoice == "1")
            {
                Entry newEntry = new Entry();
                newEntry._promptText = prompts.GetRandomPrompt();
                Console.WriteLine(newEntry._promptText);
                Console.Write("> ");
                newEntry._entryText = Console.ReadLine();
                DateTime theCurrentTime = DateTime.Now;
                newEntry._date = theCurrentTime.ToShortDateString();
                theJournal.AddEntry(newEntry);
            }

            if (userChoice == "2")
            {
                theJournal.DisplayAll();
            }

            if (userChoice == "3")
            {
                Console.Write("What filename would you like to use? ");
                string file = Console.ReadLine();
                theJournal.SaveToFile(file);
            }
            
            if (userChoice == "4")
            {
                theJournal._entries.Clear();
                Console.Write("What file do you want to load?");
                string file = Console.ReadLine();
                theJournal.LoadFromFile(file);
            }
        } while (userChoice != "5");
    }
}