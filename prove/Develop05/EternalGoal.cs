using System;

public class EternalGoal : Goal
{
    public EternalGoal(string goalName, string goalDescription, int goalPoints) : base (goalName, goalDescription, goalPoints)
    {
        _goalName = goalName;
        _goalDescription = goalDescription;
        _goalPoints = goalPoints;
    }
    public override string CreateGoal(Goal goal)
    {
        return $"[ ] {goal.GetGoalName()} ({goal.GetGoalDescription()})";
    }
    // public override void RecordEvent(int goalNumber)
    // {

    // }
}