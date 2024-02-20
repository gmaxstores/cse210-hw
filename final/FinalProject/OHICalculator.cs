using System;

using System.Collections.Generic;

public class OHICalculator : Calculator
{
    private int _urSixPlaque;
    private int _urOnePlaque;
    private int _ulSixPlaque;
    private int _lrSixPlaque;
    private int _llOnePlaque;
    private int _llSixPlaque;
    private int _urSixCalc;
    private int _urOneCalc;
    private int _ulSixCalc;
    private int _lrSixCalc;
    private int _llOneCalc;
    private int _llSixCalc;
    private DateTime _timeee;
    private double _ohiScore;

    public OHICalculator(string name, string description, int llOnePlaque, int llSixPlaque, int lrSixPlaque, int ulSixPlaque, int urOnePlaque, int urSixPlaque, int llOneCalc, int llSixCalc, int lrSixCalc, int ulSixCalc, int urOneCalc, int urSixCalc) : base(name, description)
    {
        _urSixPlaque = urSixPlaque;
        _urOnePlaque = urOnePlaque;
        _ulSixPlaque = ulSixPlaque;
        _lrSixPlaque = lrSixPlaque;
        _llOnePlaque = llOnePlaque;
        _llSixPlaque = llSixPlaque;
        _urSixCalc = urSixCalc;
        _urOneCalc = urOneCalc;
        _ulSixCalc = ulSixCalc;
        _lrSixCalc = lrSixCalc;
        _llOneCalc = llOneCalc;
        _llSixCalc = llSixCalc;

    }

    public override void Calculate()
    {
        _timeee = DateTime.Now;
        double plaqueScore = (_llOnePlaque+_llSixPlaque+_lrSixPlaque+_ulSixPlaque+_urOnePlaque+_urSixPlaque)/6;
        double calculusScore = (_llOneCalc+_llSixCalc+_lrSixCalc+_ulSixCalc+_urOneCalc+_urSixCalc)/6;
        _ohiScore = plaqueScore + calculusScore;
    }

    public override string GradingMsg()
    {
        string msg = "";
        if (_ohiScore <= 1.2)
        {
            msg = "Your OHI score is good.\nYou have a good oral hygiene.\nKindly continue your oral hygiene technique.";
        }
        else if (_ohiScore > 1.2 && _ohiScore <= 3)
        {
            msg = "Your OHI is Fair.\nKindly see a dentist to get your mouth washed.";
        }
        else if (_ohiScore > 3)
        {
            msg = "Your OHI is poor.\nKindly see a dentist as soon as possible to wash your mouth and give you preferred oral hygiene technique.";
        }
        return msg;
    }

    public override string GetDetailsString()
    {
        return $"{GetName()}: Your OHI-Score recorded on the {_timeee} is {_ohiScore}\nRecommendation:\n{GradingMsg()}";
    }

    public override string GetRepresentationString()
    {
        return $"OHI*{GetName()},{_llOnePlaque},{_llSixPlaque},{_lrSixPlaque},{_ulSixPlaque},{_urOnePlaque},{_urSixPlaque},{_llOneCalc},{_llSixCalc},{_lrSixCalc},{_ulSixCalc},{_urOneCalc},{_urSixCalc},{_timeee},{_ohiScore}";
    }

    public void SetTime(DateTime time)
    {
        _timeee = time;
    }

    public double GetScore()
    {
        return _ohiScore;
    }

    public void SetScore(double score)
    {
        _ohiScore = score;
    }

}