using System;

public class Activity
{
    protected string _activityName;
    protected string _description;
    protected int _duration;
    protected List<string> _spinnerLines = new List<string> {"|","/","-","\\","|","/", "-"};

    public Activity() 
    {
        // Keep this constructor empty and use the child classes to assign values to protected variables.
    }

    public void DisplayStartMessage()
    {
        Console.Clear(); // Clear screen
        Console.WriteLine($"Welcome to the {_activityName} activity.\n");
        Console.WriteLine($"{_description}\n");
        Console.Write("How long, in seconds, would you like your session to be? ");
    }

    public void DisplayEndMessage(int _duration)
    {
        Console.WriteLine("Well done!");
        PauseSpinner(3);
        Console.WriteLine($"You have completed another {_duration} seconds of the {_activityName}");
        PauseSpinner(3);
    }

    public void PauseSpinner(int time)
    {
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(time);

        int i = 0;

        while (DateTime.Now < endTime)
        {
            string s = _spinnerLines[i];
            Console.Write(s);
            Thread.Sleep(500);
            Console.Write("\b \b");

            i++;

            if (i >= _spinnerLines.Count)
            {
                i = 0;
            }
        }        
    }

    public void PauseCountdownTimer(int time)
    {
        for (int i = time; i > 0; i--)
        {
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }
    }
}