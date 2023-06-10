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

    // Variables to save and load prompt answers
    public List<string> _listAnswers = new List<string>();
    public List<string> _pastAnswers = new List<string>();
    private string _answer;

    public ListingActivity() // Constructor to define activity name and description
    {
        _activityName = "Listing Activity";
        _description = "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.";
        // _activityCount = ActivityCount();
    }   

    public void StartListingActivity(int duration) // Run the activity
    {
        string prompt = GetListPrompt();

        // Tell the user to prepare to begin and pause for several seconds
        Console.Clear();
        Console.Write("Get Ready... \n");
        PauseSpinner(3);

        // Display the prompt
        Console.WriteLine("List as many responses you can to the following prompt: ");
        Console.Write($"--- {prompt} ---\n");

        Console.Write("You may begin in: ");
        PauseCountdownTimer(5);
        Console.WriteLine();

        // Get answers to prompt questions for the specified duration
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(duration);

        while (DateTime.Now < endTime)
        {
            Console.Write("> ");
            _answer = Console.ReadLine();
            _listAnswers.Add(_answer);
        }

        Console.WriteLine($"You listed {GetListCount()} items!");
        Console.Write("Would you like to save your answers (y/n)? ");
        string response = Console.ReadLine();

        if (response == "y")
        {
            SaveLog(prompt);
        }

        Console.Write("Would you like to view your past answers (y/n)? ");
        string response2 = Console.ReadLine();

        if (response2 == "y")
        {
            DisplayPastAnswers(prompt);
        }
    }

    public void SaveLog(string prompt)
        {
            Console.Write("\nSaving answers to 'mylog.txt'");
            for (int i = 3; i > 0; i--)
            {
                Console.Write(".");
                Thread.Sleep(1000);
            }
            Console.WriteLine();

            // if (_pastAnswers != null)
            // {
            //     foreach (string answer in _listAnswers)
            //     {
            //         _pastAnswers.Add(answer);
            //     }

            //     _listAnswers = _pastAnswers;
            // }

            using (StreamWriter outputfile = new StreamWriter("mylog.txt"))
            {
                foreach(string answer in _listAnswers)
                {
                    outputfile.WriteLine(answer);
                }
            }            
        }

    public string GetListPrompt() // Get a random prompt
    {
        _numListingPrompts = _listingPrompts.Count() - 1;
        _randomNumber = rnd.Next(0,_numListingPrompts);
        _randomListingPrompt = _listingPrompts[_randomNumber];
        return _randomListingPrompt;
    }

    public int GetListCount()
    {
        return _listAnswers.Count();
    }

     public void DisplayPastAnswers(string prompt)
    {
        Console.Write("\nLoading file");
        for (int i = 3; i > 0; i--)
        {
            Console.Write(".");
            Thread.Sleep(1000);
        }
        Console.WriteLine();

        string[] pastAnswers = System.IO.File.ReadAllLines("mylog.txt");
        _pastAnswers = pastAnswers.ToList();
        
        foreach (string line in _pastAnswers)
        {
            Console.WriteLine($"{line}");
        }
    }

    // public int ActivityCount()
    // {
    //     _activityCount += 1;
    //     return _activityCount;
    // }
}