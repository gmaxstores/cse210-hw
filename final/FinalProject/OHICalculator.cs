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

    public override double Calculate()
    {
        double plaqueScore = (_llOnePlaque+_llSixPlaque+_lrSixPlaque+_ulSixPlaque+_urOnePlaque+_urSixPlaque)/6;
        double calculusScore = (_llOneCalc+_llSixCalc+_lrSixCalc+_ulSixCalc+_urOneCalc+_urSixCalc)/6;
        return plaqueScore + calculusScore;
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