using System;

public class ChecklistGoal : Goal
{
    private int _bonusPoints;
    private int _targetAmount;
    private int _actualAmount;  
    public ChecklistGoal(string goalName, string goalDescription, int goalPoints, int targetAmount, int bonusPoints) : base (goalName, goalDescription, goalPoints)
    {
        _goalName = goalName;
        _goalDescription = goalDescription;
        _goalPoints = goalPoints;
        _targetAmount = targetAmount;
        _bonusPoints = bonusPoints;
    }
    
    public override string CreateGoal(Goal goal)
    {
        return $"[ ] {goal.GetGoalName()} ({goal.GetGoalDescription()}) -- Currently Completed {_actualAmount}/{_targetAmount}";
    }

    // public override void DisplayGoal(Goal goal)
    // {
        
    // }
    // public override void RecordEvent(int goalNumber)
    // {
        
    // }
    
    // public bool IsComplete()
    // {

    // }
}