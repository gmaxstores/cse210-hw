using System;

public class MathAssignment : Assignment
{
    private string _textbookSection;
    private string _problems;

    public MathAssignment(string studentName, string topic, string section, string problems) : base(studentName, topic)
    {
        _problems = problems;
        _textbookSection = section;
    }

    public string GetHomeworkList()
    {
        return $"Section: {_textbookSection}, Problems: {_problems}";
    }
}