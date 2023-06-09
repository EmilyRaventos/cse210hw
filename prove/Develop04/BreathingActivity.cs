using System;
public class BreathingActivity: Activity
{
    public BreathingActivity() // Set activity name and description and ask for duration
    {
        _activityName = "Breathing Activity";
        _description = "This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing";
    }

    public void StartBreathingActivity(int duration)
    {
        // Tell the user to prepare to begin and pause for several seconds
        Console.Write("Get Ready... \n");
        PauseSpinner(3);

        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(duration);

        while (DateTime.Now < endTime)
        {
            // Display message then countdown for 5 seconds
            Console.Write("Breathe in...");
            PauseCountdownTimer(4);
            Console.WriteLine();

            // Display message then countdown for 5 seconds
            Console.Write("Now breathe out... ");
            PauseCountdownTimer(5);
            Console.WriteLine();
        }
    }
}