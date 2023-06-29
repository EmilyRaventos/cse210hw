using System;

public class SimpleGoal : Goal
{
    public SimpleGoal(string goalName, string goalDescription, int goalPoints) : base (goalName, goalDescription, goalPoints)
    {
        _goalName = goalName;
        _goalDescription = goalDescription;
        _goalPoints = goalPoints;
    }

    public override string CreateGoal(Goal goal)
    {
        return $"[ ]~~{goal.GetGoalName()}~~{goal.GetGoalDescription()}~~{goal.GetGoalPoints()}";
    }
}