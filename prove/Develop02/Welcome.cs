using System;
using Program;

namespace WelcomeUser
{
    public class Welcome
    {
        string _loggingIn = "yes";
        string _userName = "letmein";
        string _password = "please";
        string _userEntry1;
        string _userEntry2;
        string _choice;

        // Ask user for credentials
        public void UserLogin()
        {
            while (_loggingIn == "yes")
            {
                // Prompt user for username and password.
                Console.Write("Username: ");
                _userEntry1 = Console.ReadLine();
                Console.Write("Password: ");
                _userEntry2 = Console.ReadLine();

                // Validate credentials.
                if (_userEntry1 == _userName && _userEntry2 == _password)
                {
                    Console.WriteLine("Log in successful!\n");
                    _loggingIn = "no";
                }
                else
                {
                    Console.WriteLine("Log in unsuccessful. Please enter valid login credentials.");
                }
            }
        }

        // Display Menu and ask user for choice.
        public string DisplayMenu()
        {
            Console.WriteLine("Please select one of the following choices: ");
            Console.WriteLine("1. Write\n2. Display\n3. Load\n4. Save\n5. Quit");
            Console.WriteLine("What would you like to do?");
            string _choice = Console.ReadLine();
            return _choice;
        }
    }
}