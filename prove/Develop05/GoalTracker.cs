// using System;

// public class GoalTracker
// {
//     private List<Goal> _goals = new List<Goal>();
//     private int _totalPoints;
//     private string _filename;

//     public GoalTracker()
//     {
//     }

//     public void DisplayAllGoals(List<Goal> _goals)
//     {
//         int i = 1;
//         foreach (Goal goal in _goals)
//         {
//             Console.WriteLine($"{i}. {goal}");
//             i ++;
//         }
//     }
//     public void AddGoal(Goal goal)
//     {
//         // goal = $"[{isComplete}] {}"
//         _goals.Add(goal);
//     }

//     public void SaveGoals(string _filename)
//     {

//     }
//     public  List<Goal> LoadGoals(string _filename)
//     {
//         return _goals;
//     }
//     public int GetTotalPoints()
//     {
//         return _totalPoints;
//     }
//     public void DisplayTotalPoints()
//     {

//     }
// }