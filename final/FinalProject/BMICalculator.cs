using System;

using System.Collections.Generic;

public class BMICalculator : Calculator
{
    private double _height;
    private double _weight;

    public BMICalculator(string name, string description, double height, double weight) : base(name, description)
    {
        _height = height;
        _weight = weight;
    }

    public override double Calculate()
    {
        return _weight / (_height * _height);
    }

    public override string GradingMsg()
    {
        return "";
    }

    public override string GetDetailsString()
    {
        return "";
    }

    public override string GetRepresentationString()
    {
        return "";
    }
}