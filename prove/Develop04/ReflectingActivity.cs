using System;

public class ReflectingActivity : Activity 
{
    // Variables to create a list from the file of prompts
    static string[] _promptsArray = System.IO.File.ReadAllLines("prompts.txt");
    static List<string> _prompts = _promptsArray.ToList();

    // Variables to generate a random number to pick a prompt
    Random rnd = new Random();
    private int _numPrompts;
    private int _randomNumber;
    private string _randomPrompt;
   
    // Variables to create a list from the file of prompt questions
    static string[] _questionsArray = System.IO.File.ReadAllLines("questions.txt");
    static List<string> _questions = _questionsArray.ToList();
    private int _numQuestions = _questions.Count();
    private string _randomPromptQuestion;

    public ReflectingActivity() // Display activity name and description and ask for duration
    {
        _activityName = "Reflecting Activity";
        _description = "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.";
    }

    public void StartReflectingActivity(int _duration)
    {
        // Tell the user to prepare to begin and pause for several seconds
        Console.Clear();
        Console.Write("Get Ready... \n");
        PauseSpinner(3);

        Console.WriteLine("Consider the following prompt: ");
        Console.Write($"--- ");
        DisplayPrompt();
        Console.Write(" ---\n");

        Console.WriteLine("When you have something in mind, press enter to continue.");
        string ready = Console.ReadLine();

        if (ready != null)
        {
            DisplayPromptQuestionAndGetAnswers(_duration);
        }
    }

    public string GetRandomPrompt() // Get's a random prompt
    {
        _numPrompts = _prompts.Count() - 1;
        _randomNumber = rnd.Next(0,_numPrompts);
        _randomPrompt = _prompts[_randomNumber];
        return _randomPrompt;
    }

    public string GetRandomPromptQuestion() // Get's a random prompt question
    {
        _numQuestions = _questions.Count() - 1;
        _randomNumber = rnd.Next(0, _numQuestions);
        _randomPromptQuestion = _questions[_randomNumber];
        return _randomPromptQuestion;
    }

    public void DisplayPrompt() // Displays the chosen prompt
    {
        Console.Write(GetRandomPrompt());
    }

    public void DisplayPromptQuestionAndGetAnswers(int _duration)
    {
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(_duration);

        Console.WriteLine("Now ponder each of the following questions as they related to this experience.");
        Thread.Sleep(750);
        Console.Write("You may begin in: ");
        PauseCountdownTimer(3);
        Console.WriteLine();

        while (DateTime.Now < endTime)
        {
            Console.WriteLine($"> {GetRandomPromptQuestion()}");
            PauseSpinner(7);
        }
    }
}