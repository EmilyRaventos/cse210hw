using System;

public class ListingActivity : Activity
{
    // Variables to create a list from the file of prompts
    static string[] _listingsArray = System.IO.File.ReadAllLines("listingActivityFile.txt");
    static List<string> _listingPrompts = _listingsArray.ToList();

    // Variables to generate a random number to pick a prompt
    Random rnd = new Random();
    private int _numListingPrompts;
    private int _randomNumber;
    private string _randomListingPrompt;

    // Variables for something with the prompt answers
    private List<string> _listingPromptAnswers;
    private string _answer;

    public ListingActivity()
    {
        _activityName = "Listing Activity";
        _description = "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.";
    }   

    public void StartListingActivity()
    {
        // Tell the user to prepare to begin and pause for several seconds
        Console.Clear();
        Console.Write("Get Ready... \n");
        PauseSpinner(3);

        Console.WriteLine("List as many responses you can to the following prompt: ");
        Console.Write($"--- {GetListPrompt()} ---\n");

        Console.Write("You may begin in: ");
        PauseCountdownTimer(5);
        Console.WriteLine();

        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(_duration);

        while (DateTime.Now > endTime) // this loop never ends because it says ">", but "<" causes an error.
        {
            Console.Write("> ");
            _answer = Console.ReadLine();
            // _listingPromptAnswers.Add(_answer);
        }

        Console.WriteLine($"You listed {GetListCount()} items!");
    }

    public string GetListPrompt()
    {
        _numListingPrompts = _listingPrompts.Count() - 1;
        _randomNumber = rnd.Next(0,_numListingPrompts);
        _randomListingPrompt = _listingPrompts[_randomNumber];
        return _randomListingPrompt;
    }

    public int GetListCount()
    {
        return _listingPromptAnswers.Count();
    }
}