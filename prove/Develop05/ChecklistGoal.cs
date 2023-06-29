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
        return $"[ ]~~{goal.GetGoalName()}~~{goal.GetGoalDescription()}~~{goal.GetGoalPoints()}~~{GetActual()}~~{GetTarget()}~~{GetBonus()}";
    }

    public int GetActual()
    {
        return _actualAmount;
    }

    public void SetActual(int actualAmount)
    {
        _actualAmount = actualAmount;
    }

    public int GetTarget()
    {
        return _targetAmount;
    }

    public void SetTarget(int targetAmount)
    {
        _targetAmount = targetAmount;
    }

    public int GetBonus()
    {
       return _bonusPoints;
    }

    public void SetBonus(int bonusPoints)
    {
        _bonusPoints = bonusPoints;
    }
}