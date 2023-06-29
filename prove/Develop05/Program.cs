using System;

class Program
{
    static List<Goal> _goals = new List<Goal>();
    static List<string> _listOfGoals = new List<string>();
    static int _totalPoints = 0;
    static int _bonusPoints = 0;
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
                    AddGoal(g.CreateGoal(g));
                }

                // Create an eternal goal
                else if (secondChoice == "2")
                {
                    EternalGoal g = new EternalGoal(goalName, goalDescription, goalPoints);
                    AddGoal(g.CreateGoal(g));
                }

                // Create a checklist goal
                else if (secondChoice == "3")
                {
                    Console.Write("How many times does this goal need to be accomplished for a bonus? ");
                    int targetAmount = Convert.ToInt32(Console.ReadLine());

                    Console.Write("What is the bonus for accomplishing it that many times? ");
                    int bonusPoints = Convert.ToInt32(Console.ReadLine());

                    ChecklistGoal g = new ChecklistGoal(goalName, goalDescription, goalPoints, targetAmount, bonusPoints);
                    AddGoal(g.CreateGoal(g));
                }
            }    

            // Display list of goals
            else if (_choice == "2")
            {
                DisplayAllGoals();

                if ( (_listOfGoals!= null) && (!_listOfGoals.Any()) )
                {
                    Console.WriteLine("No goals to display. Type '1' to write a goal or '4' to load past goals.");
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
                foreach (string goal in _listOfGoals)
                {
                    char ch = '~';
                    int freq = goal.Count(f => (f == ch));

                    string[] parts = goal.Split("~~");

                    if (parts[0] == "[X]")
                    {
                        _totalPoints += Convert.ToInt32(parts[3]);
                    }
                    if (freq > 6 && Convert.ToInt32(parts[4]) != 0)
                    {
                        _totalPoints += Convert.ToInt32(parts[4]) * Convert.ToInt32(parts[3]);
                    }
                }
            }

            // Record an event
            else if (_choice == "5")
            {
                Console.WriteLine("\nWhich goal did you accomplish? ");
                DisplayGoalTitles();
                int i_goal = Convert.ToInt32(Console.ReadLine()) - 1;

                // MarkComplete(i_goal);
                string selectedGoal = _listOfGoals[i_goal];
                char ch = '~';
                int freq = selectedGoal.Count(f => (f == ch));

                string [] parts = selectedGoal.Split("~~");
                int length = parts.Length;
                string rest = "";
                    
                // If it's a simple goal or an eternal goal, check it off
                if (freq <= 6)
                {
                    for (int i = 1; i < length; i++) 
                    {
                        if (i != length - 1)
                        {
                            rest = rest + parts[i] + "~~";
                        }
                        else
                        {
                            rest = rest + parts[i];
                        }
                    }

                    selectedGoal = $"[X]~~{rest}";
                }

                // If it's a checklist goal and this is the last time needed to complete it, increase and check it off.
                else if ((freq > 6) && (Convert.ToInt32(parts[4]) == Convert.ToInt32(parts[5])-1))
                {
                    for (int i = 1; i < length; i++) 
                    {
                        if (i != length -1 && i != length - 3)
                        {
                            rest = rest + parts[i] + "~~";
                        }
                        else if (i == length - 3)
                        {
                            int actual = Convert.ToInt32(parts[i]);
                            actual += 1;
                            actual.ToString();
                            rest = rest + actual + "~~";
                        }
                        else if (i == length - 1)
                        {
                            rest = rest + parts[i];
                        }
                    } 
                    selectedGoal = $"[X]~~{rest}";
                    _bonusPoints = Convert.ToInt16(parts[length-1]);
                }

                // If it's a checklist goal that is not complete, increase the amount.
                else
                {
                    for (int i = 0; i < length; i++) 
                    {
                        if (i != length -1 && i != length - 3)
                        {
                            rest = rest + parts[i] + "~~";
                        }
                        else if (i == length - 3)
                        {
                            int actual = Convert.ToInt32(parts[i]);
                            actual += 1;
                            actual.ToString();
                            rest = rest + actual + "~~";
                        }
                        else if (i == length - 1)
                        {
                            rest = rest + parts[i];
                        }
                    }
                    selectedGoal = rest;
                }

                _listOfGoals[i_goal] = selectedGoal;
                int earnedPoints = Convert.ToInt32(parts[3]) + _bonusPoints;
                _totalPoints += Convert.ToInt32(parts[3]) + _bonusPoints;
            
                Console.WriteLine($"Congratulations! You've earned {earnedPoints} points!");
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

    // Methods for all choices

    // Display the current list of goals
    static void DisplayAllGoals()
    {
        int i = 1;
        foreach (string goal in _listOfGoals)
        {
            string [] parts = goal.Split("~~");
            char ch = '~';
            int freq = goal.Count(f => (f == ch));

            if (freq <= 6)
            {
                Console.WriteLine($"{i}. {parts[0]} {parts[1]} ({parts[2]})");
            }
            else
            {
            Console.WriteLine($"{i}. {parts[0]} {parts[1]} ({parts[2]}) -- Currently completed: {parts[4]}/{parts[5]}");
            }
            i ++;
        }
    }
    
    // Display the goal title to record an event
    static void DisplayGoalTitles()
    {
        int k = 1;

        foreach (string goal in _listOfGoals)
        {
            string [] parts = goal.Split("~~");
            Console.WriteLine($"{k}. {parts[1]}");
            k++;
        }
    }

    // Add the newly created goal to the list of goals
    static void AddGoal(string goal)
    {
        _listOfGoals.Add(goal);
    }

    // Save goals to a file called "mygoals.txt"
    static void SaveGoals(List<string> _listOfGoals)
    {
        Console.Write("\nSaving goals to 'goals.txt'");
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
                using (StreamWriter outputfile = new StreamWriter("goals.txt"))
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

        int j = 0;

        string[] pastGoals = System.IO.File.ReadAllLines("goals.txt");
        List<string> _pastGoalsList = pastGoals.ToList();
        foreach (string goal in _pastGoalsList)
        {
            _listOfGoals.Insert(j, goal);
            j++;
        }
        return _listOfGoals;
    }
}