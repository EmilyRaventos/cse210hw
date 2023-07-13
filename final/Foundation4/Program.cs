using System;

public class Program
{
    static List<Activity> _listOfActivities;
    static void Main(string[] args)
    {
        List<Activity> listOfActivities = new List<Activity>();
        _listOfActivities = listOfActivities;

        Biking a1 = new Biking("03 November 2022", 30, 8);
        Running a2 = new Running("12 January 2023", 20, 3);
        Swimming a3 = new Swimming("24 April 2023", 60, 30);

        _listOfActivities.Add(a1);
        _listOfActivities.Add(a2);
        _listOfActivities.Add(a3);

        foreach (Activity activity in _listOfActivities)
        {
            activity.GetSummary(activity);
        }
    }
}