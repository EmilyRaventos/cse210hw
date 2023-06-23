using System;

class Program
{
    static List<Goal> _goals = new List<Goal>();
    static List<string> _listOfGoals = new List<string>();
    static List<string> _goalTitles = new List<string>();
    static int _totalPoints = 0;
    static List<int> _pointsList = new List<int>();
    static bool notDone;
    static bool isEmpty;

    // Start Goal Program
    static void Main()
    {
        while (!notDone)
        {
            Console.WriteLine($"\nYou have {_totalPoints} points.\n");
            Console.WriteLine("Menu Options:");
            Console.WriteLine("1. Create New Goal\n2. List Goals\n3. Save Goals\n4. Load Goals\n5. Record Event\n6. Quit");
            Console.Write("Select a choice from the menu: ");
            string _choice = Console.ReadLine();
            Console.WriteLine();

            if (_choice == "1")
            {
                // Display the menu for goal types
                Console.WriteLine("The types of Goals are: ");
                Console.WriteLine("1. Simple Goal\n2. Eternal Goal\n3. Checklist Goal");
                Console.Write("Which type of goal would you like to create? ");
                string secondChoice = Console.ReadLine();

                // Get goal name, description, and points
                Console.Write("What is the name of your goal? ");
                string goalName = Console.ReadLine();

                Console.Write("What is a short description of it? ");
                string goalDescription = Console.ReadLine();

                Console.Write("How many points do you want associated with this goal? ");
                int goalPoints = Convert.ToInt32(Console.ReadLine());

                // Create a simple goal
                if (secondChoice == "1")
                {
                    SimpleGoal g = new SimpleGoal(goalName, goalDescription, goalPoints);
                    AddGoal(g);
                    _pointsList.Add(goalPoints);
                }

                // Create an eternal goal
                else if (secondChoice == "2")
                {
                    EternalGoal g = new EternalGoal(goalName, goalDescription, goalPoints);
                    AddGoal(g);
                    _pointsList.Add(goalPoints);
                }

                // Create a checklist goal
                else if (secondChoice == "3")
                {
                    Console.Write("How many times does this goal need to be accomplished for a bonus? ");
                    int targetAmount = Convert.ToInt32(Console.ReadLine());

                    Console.Write("What is the bonus for accomplishing it that many times? ");
                    int bonusPoints = Convert.ToInt32(Console.ReadLine());

                    ChecklistGoal g = new ChecklistGoal(goalName, goalDescription, goalPoints, targetAmount, bonusPoints);
                    AddGoal(g);
                    _pointsList.Add(goalPoints);
                }
            }    

            // Display list of goals
            else if (_choice == "2")
            {
                DisplayAllGoals();

                if ( (_listOfGoals!= null) && (!_listOfGoals.Any()) )
                {
                    Console.WriteLine("No goals to display. Type '1' to write a goal.");
                }
            }

            // Save goals to file
            else if (_choice == "3")
            {
                SaveGoals(_listOfGoals);
            }

            // Load goals from file
            else if (_choice == "4")
            {
                LoadGoals();
            }

            // Record an event
            else if (_choice == "5")
            {
                Console.WriteLine("\nWhich goal did you accomplish? ");
                DisplayGoalTitles();
                int i_goal = Convert.ToInt32(Console.ReadLine()) - 1;

                // MarkComplete(i_goal);
                string selectedGoal = _listOfGoals[i_goal];
                string completedGoal = selectedGoal.Replace("[ ]", "[X]");
                _listOfGoals[i_goal] = completedGoal;

                Console.WriteLine($"Congratulations! You've earned ___ points!");
                Console.WriteLine($"You now have {_totalPoints} points.");
            }

            // Quit goal program
            else if (_choice == "6")
            {
                Console.WriteLine("Thank you. Good bye.");
                notDone = true;
            }
        }
    }
    // using(StreamReader reader = new StreamReader("goals.txt"))
    // {

    // }

    // Methods for all choices

    // Display the current list of goals
    static void DisplayAllGoals()
    {
        int i = 1;

        foreach (string goal in _listOfGoals)
        {
            Console.WriteLine($"{i}. {goal}");
            i++;
        }
    }
    
    // Display the goal title to record an event
    static void DisplayGoalTitles()
    {
        int k = 1;

        foreach (string title in _goalTitles)
        {
            Console.WriteLine($"{k}. {title}");
        }
        k++;
    }

    // Add the newly created goal to the list of goals
    static void AddGoal(Goal goal)
    {
        _listOfGoals.Add(goal.CreateGoal(goal));
        _goalTitles.Add(goal.GetGoalName());
    }

    // Save goals to a file called "mygoals.txt"
    static void SaveGoals(List<string> _listOfGoals)
    {
        Console.Write("\nSaving goals to 'mygoals.txt'");
        for (int i = 3; i > 0; i--)
        {
            Console.Write(".");
            Thread.Sleep(1000);
        }
        Console.WriteLine();

        // Check if there are any new goals to add.
        bool isEmpty = _listOfGoals.Any();

            if (isEmpty)
            {
                using (StreamWriter outputfile = new StreamWriter("mygoals.txt"))
                {
                    foreach(string goal in _listOfGoals)
                    {
                        outputfile.WriteLine(goal);
                    }
                }
            }
            else
            {
                Console.WriteLine("No goals to save. Type '1' to write a goal.\n ");
            }

            // Create file for list of Goals --- doesn't work ----
            using (StreamWriter outputfile = new StreamWriter("thegoals.txt"))
            {
                foreach(Goal goal in _goals)
                {
                    outputfile.WriteLine(goal);
                }
            }

            // Create file for list of goal titles
            using (StreamWriter outputfile = new StreamWriter("goalTitles.txt"))
            {
                foreach(string title in _goalTitles)
                {
                    outputfile.WriteLine(title);
                }
            }

            // Create file for points
            using (StreamWriter outputfile = new StreamWriter("pointTracker.txt"))
            {
                foreach(int point in _pointsList)
                {
                    outputfile.WriteLine(point);
                }
            }
    }

    // Load Goals from previously saved file
    static List<string> LoadGoals()
    {
        Console.Write("\nLoading file");
        for (int i = 3; i > 0; i--)
        {
            Console.Write(".");
            Thread.Sleep(1000);
        }
        Console.WriteLine();
        
        // Stupid way to keep track of points to add up on completion
        int k = 0;
        string[] pastPoints = System.IO.File.ReadAllLines("pointTracker.txt");
        List<string> _pastPointList = pastPoints.ToList();
        foreach (string point in _pastPointList)
        {
            _pointsList.Insert(k, Convert.ToInt32(point));
            k++;
        }

        int h = 0;

        string[] pastTitles = System.IO.File.ReadAllLines("goalTitles.txt");
        List<string> _pastTitlesList = pastTitles.ToList();
        foreach (string title in _pastTitlesList)
        {
            _goalTitles.Insert(h, title);
            h++;
        }

        int j = 0;

        string[] pastGoals = System.IO.File.ReadAllLines("mygoals.txt");
        List<string> _pastGoalsList = pastGoals.ToList();
        foreach (string goal in _pastGoalsList)
        {
            _listOfGoals.Insert(j, goal);
            j++;
        }
        return _listOfGoals;
    }

    // // Mark the goal as complete
    // static void MarkComplete(int i_goal)
    // {
    //     string selectedGoal = _listOfGoals[i_goal];
    //     string search = "--";

    //     if (selectedGoal.Contains(search))
    //     {
    //         if (_actualAmount == _targetAmount)
    //         {
    //             string completedGoal = selectedGoal.Replace("[ ]", "[X]");
    //             _listOfGoals[i_goal] = completedGoal;
    //         }   
    //         else
    //         {
                
    //         }
    //     }
    //     else
    //     {
    //         string completedGoal = selectedGoal.Replace("[ ]", "[X]");
    //         _listOfGoals[i_goal] = completedGoal;
    //     }
    // }
}