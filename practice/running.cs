using System;

public class Running : Activity
{
    private double _distance;

    public Running (string date, int length, double distance)
    {
        _date = date;
        _length = length;
        _distance = distance;
        _type = "Running";
    }

    public override double GetSpeed()
    {
        return (_distance / _length) * 60;
    }

    public override double GetPace()
    {
        return _length / _distance;
    }

    public override double GetDistance()
    {
        return _distance;
    }
}