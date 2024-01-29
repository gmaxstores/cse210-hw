using System;

class Program
{
    static void Main(string[] args)
    {
        Assignment assignment = new Assignment("Maxwell Nvani", "Division");
        MathAssignment mathAssignment = new MathAssignment("maxwell Nvani", "Fraction", "37", "2-30");
        WritingAssignment writingAssignment = new WritingAssignment("Maxwell Nvani", "Synonyms", "Joseph Goes to School");
        Console.WriteLine(assignment.GetSummary());
        Console.WriteLine(mathAssignment.GetHomeworkList());
        Console.WriteLine(mathAssignment.GetSummary());
        Console.WriteLine(writingAssignment.GetWritingInfo());
        Console.WriteLine(writingAssignment.GetSummary());

    }
}