using System;

public class Biking : Activity
{
    private double _speed; // (distance / minutes) * 60
   
    public Biking (string date, int length, double speed)
    {
        _date = date;
        _length = length;
        _speed = speed;
        _type = "Biking";
    }

    public override double GetDistance()
    {
        return _speed / 60 * _length;
    }

    public override double GetSpeed()
    {
        return _speed;
    }

    public override double GetPace()
    {
        return _length / GetDistance();
    }
}