using System;

public abstract class Goal
{
    protected string _goalType;
    protected string _goalName;
    protected string _goalDescription;
    protected int _goalPoints;
    protected bool isCompleted;
    protected int _goalNumber;
    public Goal(string goalName, string goalDescription, int goalPoints)
    {
        _goalName = goalName;
        _goalDescription = goalDescription;
        _goalPoints = goalPoints;
    }

    public abstract string CreateGoal(Goal goal);
    // public abstract void DisplayGoal(Goal goal);
    // public abstract void RecordEvent(int goalNumber);

    // public bool IsComplete()
    // {
    //     return true;
    // }

    public string GetGoalName()
    {
        return _goalName;
    }

    public string GetGoalDescription()
    {
        return _goalDescription;
    }
}