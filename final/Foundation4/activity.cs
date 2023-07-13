using System;

public abstract class Activity
{
    protected string _date;
    protected int _length; // in minutes
    protected string _type;

    public Activity()
    {
        // Keep this constructor empty and use the child classes to assign values to protected variables.
    }
    public virtual double GetDistance()
    {
        double _distance = 0;
        return _distance;
    }

    public virtual double GetSpeed()
    {
        double _speed = 0;
        return _speed;
    }

    public virtual double GetPace()
    {
        double _pace = 0;
        return _pace;
    }
    public void GetSummary(Activity activity)
    {
        Console.WriteLine($"{_date} - {_type} ({_length} min) - Distance: {activity.GetDistance()} miles, Speed: {activity.GetSpeed()} mph, Pace: {Math.Round(activity.GetPace(), 2)} min per mile");
    }
}