using System;

using System.Collections.Generic;

public class BMICalculator : Calculator
{
    private double _height;
    private double _weight;
    private DateTime _time;
    private double _bmiScore;

    public BMICalculator(string name, double height, double weight) : base(name)
    {
        _height = height;
        _weight = weight;
    }

    public override void Calculate()
    {
        _time = DateTime.Now;

        _bmiScore = _weight / (_height * _height);
    }

    public override string GradingMsg()
    {
        string msg = "";
        if (_bmiScore < 18.5)
        {
            msg = "You are underweight\nKindly eat more healthy food.\n";
        }
        else if (_bmiScore >= 18.5 && _bmiScore <= 24.9)
        {
            msg = "You have a healthy weight.\nKeep the routine going to maintain this weight.\n";
        }
        else if (_bmiScore >= 25 && _bmiScore <= 29.9)
        {
            msg = "You are overweight.\nKindly exercise more to watch your weight.\n";
        }
        else if (_bmiScore >= 30)
        {
            msg = "You are obesed.\nKindly engage in routine exercises, watch your diet and see a doctor immediately.\n";
        }
        return msg;
    }

    public override string GetDetailsString()
    {
        return $"{GetName()}: Your BMI recorded on the {_time} for height :- {_height} and weight:- {_weight} is {_bmiScore}\nRecommendation:\n{GradingMsg()}";
    }

    public override string GetRepresentationString()
    {
        return $"BMI*{GetName()},{_height},{_weight},{_time},{_bmiScore}";
    }
    
    public void SetTime(DateTime time)
    {
        _time = time;
    }

    public double GetScore()
    {
        return _bmiScore;
    }

    public void SetScore(double score)
    {
        _bmiScore = score;
    }
}