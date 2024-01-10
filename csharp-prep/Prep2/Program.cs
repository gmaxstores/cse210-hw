using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your grade?");
        string grade = Console.ReadLine();
        int gradeNumber = int.Parse(grade);
        string letter = "";
        string sign = "";
        if (gradeNumber >= 90)
        {
            letter = "A";
        }
        else if (gradeNumber >= 80)
        {
            letter = "B";
        }
        else if (gradeNumber >= 70)
        {
            letter = "C";
        }
        else if (gradeNumber >= 60)
        {
            letter = "D";
        }
        else if (gradeNumber < 60)
        {
            letter = "F";
        }
        if (gradeNumber >= 60 && gradeNumber <=96)
        {
            if ((gradeNumber%10 >= 7))
            {
                sign = "+";
            }
            else if ((gradeNumber%10 <= 3))
            {
                sign = "-";
            }
        }
        Console.WriteLine($"Your grade is {letter}{sign}");
        if (gradeNumber >= 70)
        {
            Console.WriteLine("Congratulations< You Passed this course!!!");
        }
        else if (gradeNumber < 70)
        {
            Console.WriteLine("Ooops, you failed this course. Better Luck next time!!!");
        }
    }
}