using System;

public class Swimming : Activity
{
    private int _laps;
    public Swimming (string date, int length, int laps)
    {
        _date = date;
        _length = length;
        _laps = laps;
        _type = "Swimming";
    }

    public override double GetDistance()
    {
        return (_laps * 50) / 1000 * 0.62;
    }

    public override double GetSpeed()
    {
        return (GetDistance() / _length) * 60;
    }

    public override double GetPace()
    {
        return (_length / GetDistance());
    }
}