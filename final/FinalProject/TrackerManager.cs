using System;

using System.Collections.Generic;

using System.IO;

public class TrackerManager
{
    private List<ExpensesTracker> _expenses;
    private List<PeriodTracker> _cycles;
    private List<AppointmentTracker> _appointments;
    private List<NoteTracker> _notes;

    public TrackerManager()
    {
        _appointments = new List<AppointmentTracker>();
        _cycles = new List<PeriodTracker>();
        _expenses = new List<ExpensesTracker>();
        _notes = new List<NoteTracker>();
    }

    public void Start()
    {
        string mainChoice;
        do
        {
            Console.WriteLine("1. Track a Note.\n2. Track an Appointment.\n3. Track a Period Cycle.\n4. Track expenses.\n5. Save.\n6. Load\n7. Quit");
            Console.Write("What would you like to do? ");
            mainChoice = Console.ReadLine();
            if (mainChoice == "1")
            {
                string userChoice;
                do
                {
                    Console.WriteLine("1. Create a note.\n2. List notes\n3. Quit");
                    Console.Write("What do you want to do?: ");
                    userChoice = Console.ReadLine();
                    if (userChoice == "1")
                    {
                        Console.Write("What is your name?: ");
                        string userName = Console.ReadLine();
                        Console.Write("What is the title of the note?: ");
                        string userTitle = Console.ReadLine();
                        Console.Write("Type the note here:  ");
                        string userNote = Console.ReadLine();
                        NoteTracker noteTracker = new NoteTracker(userName, userTitle, userNote);
                        _notes.Add(noteTracker);
                    }
                    else if (userChoice == "2")
                    {
                        foreach (NoteTracker nt in _notes)
                        {
                            Console.WriteLine(nt.ListDetails());
                        }
                    }
                }while (userChoice != "3");
            }
            else if (mainChoice == "2")
            {
                string userChoice;
                do
                {
                    Console.WriteLine("1. Create an appoinment.\n2. List appointments\n3. Modify an Appointment\n4. Quit");
                    Console.Write("What do you want to do?: ");
                    userChoice = Console.ReadLine();
                    if (userChoice == "1")
                    {
                        Console.Write("What is your name?: ");
                        string userName = Console.ReadLine();
                        Console.Write("What is the title of the Appointment?: ");
                        string userTitle = Console.ReadLine();
                        Console.Write("Type the description here:  ");
                        string userDesc = Console.ReadLine();
                        Console.Write("What date is this appointment (Format: dd/mm/yy time)");
                        string userDate = Console.ReadLine();
                        AppointmentTracker appointmentTracker = new AppointmentTracker(userName, userTitle, userDesc, userDate);
                        _appointments.Add(appointmentTracker);
                    }
                    else if (userChoice == "2")
                    {
                        foreach (AppointmentTracker at in _appointments)
                        {
                            Console.WriteLine(at.ListDetails());
                        }
                    }
                    else if (userChoice == "3")
                    {
                        Console.Write("What Appointment would you like to modify?: ");
                        string userInput = Console.ReadLine();
                        foreach (AppointmentTracker at in _appointments)
                        {
                            if (at.GetTitle() == userInput)
                            {
                                at.Modify();
                            }
                            else
                            {
                                Console.WriteLine("No title as such found. Try typing exactly the name of the title.");
                            }
                        }
                    }
                }while (userChoice != "4");
            }
            else if (mainChoice == "3")
            {
                string userChoice;
                do
                {
                    Console.WriteLine("1. Create a cycle date.\n2. List cycles\n3. Quit");
                    Console.Write("What do you want to do?: ");
                    userChoice = Console.ReadLine();
                    if (userChoice == "1")
                    {
                        Console.Write("What is your name?: ");
                        string userName = Console.ReadLine();
                        Console.Write("How old are you?: ");
                        string userAge = Console.ReadLine();
                        Console.Write("When did the cycle start (Format: dd/mm/yy):  ");
                        string userStartDate = Console.ReadLine();
                        Console.Write("When did the cycle end? (Format: dd/mm/yy)" );
                        string userEndDate = Console.ReadLine();
                        PeriodTracker periodTracker = new PeriodTracker(userName, userAge, userStartDate, userEndDate);
                        _cycles.Add(periodTracker);
                    }
                    else if (userChoice == "2")
                    {
                        foreach (PeriodTracker pt in _cycles)
                        {
                            Console.WriteLine(pt.ListDetails());
                        }
                    }
                }while (userChoice != "3");
            }
            else if (mainChoice == "4")
            {
                string userChoice;
                do
                {
                    Console.WriteLine("1. Track monthly expenses.\n2. List expenses\n3. Quit");
                    Console.Write("What do you want to do?: ");
                    userChoice = Console.ReadLine();
                    if (userChoice == "1")
                    {
                        Console.Write("What is your name?: ");
                        string userName = Console.ReadLine();
                        Console.Write("What is your monthly income?: ");
                        string userMonthlyIncome = Console.ReadLine();
                        Console.Write("For what month?:  ");
                        string userMonth = Console.ReadLine();
                        ExpensesTracker expensesTracker = new ExpensesTracker(userName, double.Parse(userMonthlyIncome), userMonth);
                        _expenses.Add(expensesTracker);
                        expensesTracker.Run();
                    }
                    else if (userChoice == "2")
                    {
                        foreach (ExpensesTracker et in _expenses)
                        {
                            Console.WriteLine(et.ListDetails());
                        }
                    }
                }while (userChoice != "3");
            }
            else if (mainChoice == "5")
            {
                Save();
            }
            else if (mainChoice == "6")
            {
                Load();
            }
        }while (mainChoice != "7");
    }

    public void Save()
    {
        Console.Write("What name would you like to save this file as? ");
        string userName = Console.ReadLine();
        userName = "myFile.txt";
        using (StreamWriter outputFile = new StreamWriter(userName))
        {
            foreach (AppointmentTracker at in _appointments)
            {
                outputFile.WriteLine(at.GetRepresentationString());
            }
            foreach (PeriodTracker pt in _cycles)
            {
                outputFile.WriteLine(pt.GetRepresentationString());
            }
            foreach (ExpensesTracker et in _expenses)
            {
                outputFile.WriteLine(et.GetRepresentationString());
            }
            foreach (NoteTracker nt in _notes)
            {
                outputFile.WriteLine(nt.GetRepresentationString());
            }
        }
    }

    public void Load()
    {
        Console.Write("What is the name of the file you would like to load? ");
        string userName = Console.ReadLine();
        userName = "myFile.txt";
        string[] lines = System.IO.File.ReadAllLines(userName);
        foreach (string line in lines)
        {
            string[] parts = line.Split(":");
            string trackerType = parts[0];
            string trackerDetails = parts[1];
            if (trackerType == "AppointmentTracker")
            {
                string[] data = trackerDetails.Split(",");
                AppointmentTracker appointmentTracker = new AppointmentTracker(data[0], data[1], data[2], data[3]);
                _appointments.Add(appointmentTracker);
            }
            else if (trackerType == "NoteTracker")
            {
                string[] data = trackerDetails.Split(",");
                NoteTracker noteTracker = new NoteTracker(data[0], data[1], data[2]);
                _notes.Add(noteTracker);
            }
            else if (trackerType == "PeriodTracker")
            {
                string[] data = trackerDetails.Split(",");
                PeriodTracker periodTracker = new PeriodTracker(data[0], data[1], data[2], data[3]);
                _cycles.Add(periodTracker);
            }
            else if (trackerType == "ExpensesTracker")
            {
                string[] data = trackerDetails.Split(",");
                ExpensesTracker expensesTracker = new ExpensesTracker(data[0], double.Parse(data[1]), data[2]);
                expensesTracker.SetExpensesTotal(double.Parse(data[4]));
                expensesTracker.SetNetIncome(double.Parse(data[3]));
                _expenses.Add(expensesTracker);
            }
        }
    }
}