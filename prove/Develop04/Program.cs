using System;

class Program
{
    static string _choice;
    static int _duration;
    static bool _complete = false;

    static void Main()
    {
        Activity activity = new Activity();

        while (_complete == false)
        {
            Console.Clear();
            Console.WriteLine("Menu Options: ");
            Console.WriteLine("1. Start Breathing Activity\n2. Start Reflection Activity\n3. Start Listing Activity\n4. Quit");
            Console.WriteLine("Select a choice from the menu: ");
            _choice = Console.ReadLine();

            if (_choice == "1") // Breathing Activity
            {
                BreathingActivity ba1 = new BreathingActivity();
                ba1.DisplayStartMessage();
                _duration = Convert.ToInt32(Console.ReadLine());

                ba1.StartBreathingActivity(_duration);
                ba1.DisplayEndMessage(_duration);

            }

            else if (_choice == "2") // Reflecting Activity
            {
                ReflectingActivity ra1 = new ReflectingActivity();
                ra1.DisplayStartMessage();
                _duration = Convert.ToInt32(Console.ReadLine());

                ra1.StartReflectingActivity(_duration);
                ra1.DisplayEndMessage(_duration);
            }

            else if (_choice == "3") // Listing Activity
            {
                ListingActivity la1 = new ListingActivity();
                la1.DisplayStartMessage();
                _duration = Convert.ToInt32(Console.ReadLine());

                // StartListingActivity
                
                la1.DisplayEndMessage(_duration);
            }

            else if (_choice == "4")
            {
                _complete = true;
            }

            // Add if the loop doesn't break when "4" is chosen
            // if (_complete == true)
            // {
            //     break;
            // }
        }
    }
}