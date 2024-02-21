using System;

using System.Collections.Generic;

using System.IO;

public class CalculatorManager
{
    private List<BMICalculator> _bmiScores;
    private List<OHICalculator> _ohiScores;

    public CalculatorManager()
    {
        _bmiScores = new List<BMICalculator>();
        _ohiScores = new List<OHICalculator>();
    }

    public void Start()
    {
        string mainChoice = "";
        do
        {
            Console.WriteLine("1. Calculate.\n2. List scores.\n3. Save.\n4. Load.\n5. Quit.");
            Console.Write("what would you like to do? ");
            mainChoice = Console.ReadLine();
            if (mainChoice == "1")
            {
                Console.WriteLine();
                string userChoice = "";
                do
                {
                    Console.WriteLine("What would you like to calculate?\n1. BMI.\n2. OHI.\n3. Quit.");
                    userChoice = Console.ReadLine();
                    if (userChoice == "1")
                    {
                        Console.Write("What is your name? ");
                        string userName = Console.ReadLine();
                        Console.Write("What is your height in meters? ");
                        string userHeight = Console.ReadLine();
                        double userHeightNum = double.Parse(userHeight);
                        Console.Write("What is your weight in kg? ");
                        string userWeight = Console.ReadLine();
                        double userWeightNum = double.Parse(userWeight);
                        BMICalculator newBMI = new BMICalculator(userName, userHeightNum, userWeightNum);
                        newBMI.Calculate();
                        Console.WriteLine($"Your BMI is {newBMI.GetScore()}");
                        Console.WriteLine(newBMI.GradingMsg());
                        _bmiScores.Add(newBMI);
                    }
                    else if (userChoice == "2")
                    {
                        Console.Write("What is your name? ");
                        string userName = Console.ReadLine();
                        Console.Write("What is the plaque score for Lower left central incisor? ");
                        string userllOnePlaque = Console.ReadLine();
                        Console.Write("What is the plaque score for Lower left first molar? ");
                        string userllSixPlaque = Console.ReadLine();
                        Console.Write("What is the plaque score for Lower right first molar? ");
                        string userlrSixPlaque = Console.ReadLine();
                        Console.Write("What is the plaque score for Upper left first molar? ");
                        string userulSixPlaque = Console.ReadLine();
                        Console.Write("What is the plaque score for Upper Right central incisor?  ");
                        string userurOnePlaque = Console.ReadLine();
                        Console.Write("What is the plaque score for Upper right first molar? ");
                        string userurSixPlaque = Console.ReadLine();
                        Console.Write("What is the calculus score for Lower left central incisor? ");
                        string userllOneCalc = Console.ReadLine();
                        Console.Write("What is the calculus score for Lower left first molar? ");
                        string userllSixCalc = Console.ReadLine();
                        Console.Write("What is the calculus score for Lower right first molar? ");
                        string userlrSixCalc = Console.ReadLine();
                        Console.Write("What is the calculus score for Upper left first molar? ");
                        string userulSixCalc = Console.ReadLine();
                        Console.Write("What is the calculus score for Upper Right central incisor? ");
                        string userurOneCalc = Console.ReadLine();
                        Console.Write("What is the calculus score for Upper right first molar? ");
                        string userurSixCalc = Console.ReadLine();
                        OHICalculator newOHI = new OHICalculator(userName, int.Parse(userllOnePlaque), int.Parse(userllSixPlaque), int.Parse(userlrSixPlaque), int.Parse(userulSixPlaque), int.Parse(userurOnePlaque), int.Parse(userurSixPlaque), int.Parse(userllOneCalc), int.Parse(userllSixCalc), int.Parse(userlrSixCalc), int.Parse(userulSixCalc), int.Parse(userurOneCalc), int.Parse(userurSixCalc));
                        newOHI.Calculate();
                        Console.WriteLine($"Your OHI score is {newOHI.GetScore()}");
                        Console.WriteLine(newOHI.GradingMsg());
                        _ohiScores.Add(newOHI);

                    }
                }while (userChoice != "3");
            }
            else if (mainChoice == "2")
            {
                Console.WriteLine("what scores do you want to list?\n1. BMI.\n2. OHI.");
                string userPrefList = Console.ReadLine();
                if (userPrefList == "1")
                {
                    ListBMIScores();
                }
                else if (userPrefList == "2")
                {
                    ListOHIScores();
                }
            }
            else if (mainChoice == "3")
            {
                SaveScores();
            }
            else if (mainChoice == "4")
            {
                LoadScores();
            }
        } while (mainChoice != "5");
    }


    public void ListBMIScores()
    {
        foreach (BMICalculator bmi in _bmiScores)
        {
            Console.WriteLine(bmi.GetDetailsString());
        }
    }

    public void ListOHIScores()
    {
        foreach (OHICalculator ohi in _ohiScores)
        {
            Console.WriteLine(ohi.GetDetailsString());
        }
    }

    public void SaveScores()
    {
        Console.Write("What name would you like to save this file as? ");
        string userName = Console.ReadLine();
        userName = "myCalculatorFile.txt";
        using (StreamWriter outputFile = new StreamWriter(userName))
        {
            foreach (BMICalculator bmi in _bmiScores)
            {
                outputFile.WriteLine(bmi.GetRepresentationString());
            }
            foreach (OHICalculator ohi in _ohiScores)
            {
                outputFile.WriteLine(ohi.GetRepresentationString());
            }
        }
    }

    public void LoadScores()
    {
        Console.Write("What is the name of the file you would like to load? ");
        string userName = Console.ReadLine();
        userName = "myCalculatorFile.txt";
        string[] lines = System.IO.File.ReadAllLines(userName);
        foreach (string line in lines)
        {
            string[] parts = line.Split("*");
            string calculatorType = parts[0];
            string calculatorDetails = parts[1];
            if (calculatorType == "BMI")
            {
                string[] data = calculatorDetails.Split(",");
                BMICalculator bmi = new BMICalculator(data[0], double.Parse(data[1]), double.Parse(data[2]));
                bmi.SetTime(DateTime.Parse(data[3]));
                bmi.SetScore(double.Parse(data[4]));
                _bmiScores.Add(bmi);
            }
            else if (calculatorType == "OHI")
            {
                string[] data = calculatorDetails.Split(",");
                OHICalculator ohi = new OHICalculator(data[0], int.Parse(data[1]), int.Parse(data[2]), int.Parse(data[3]), int.Parse(data[4]), int.Parse(data[5]), int.Parse(data[6]), int.Parse(data[7]), int.Parse(data[8]), int.Parse(data[9]), int.Parse(data[10]), int.Parse(data[11]), int.Parse(data[12]));
                ohi.SetTime(DateTime.Parse(data[13]));
                ohi.SetScore(double.Parse(data[14]));
                _ohiScores.Add(ohi);
            }
        }
    }
}