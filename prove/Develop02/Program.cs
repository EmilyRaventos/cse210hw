using System;
using System.IO;
using Prompts;
using Journals;
using Entries;
using WelcomeUser;

// Ways I exceeded core requirements: 
// 1. The user is required to log in to access the journal
// 2. I saved the date as the current date using Datetime.
// 3. I've added a check that skips step 4 if they try to save a 
//    current journal with no entries to avoid throwing an error. 
// 4. I've addressed the issue of the user not selecting 1-5

namespace Program
{
    class Program 
    {
        static void Main(string[] args)
        {
            // Member variables/attributes of program.
            string _journalOpen = "yes";
            string _choice;
            string _entry;

            // Create an instance for a welcome page, prompt, journal, and entry.
            Welcome welcome = new Welcome();
            Prompt prompt = new Prompt();
            Journal journal = new Journal();
            Entry entry = new Entry();

            // Start of Program
            Console.WriteLine("Welcome to the Journal Program! ");

            while (_journalOpen == "yes") 
            {
                welcome.UserLogin();
               _choice = welcome.DisplayMenu();

                // Generate a random prompt, create an entry, and add entry to journal.
                if (_choice == "1") 
                {
                    string newPrompt = prompt.GetPrompt();
                    _entry = entry.CreateEntry(newPrompt);
                    journal.AddToJournal(_entry);
                }

                // Display the entries in the current journal. 
                else if (_choice == "2")
                {
                    journal.DisplayEntries();
                }

                // Load entries from a previously saved file.
                else if (_choice == "3")
                {
                    journal.LoadJournal();
                }

                // Create a file and save the current journal entries there.
                else if (_choice == "4")
                {
                    journal.SaveJournal();
                }

                // Close the journal and exit the loop.
                else if (_choice == "5")
                {
                    _journalOpen = "no";
                }

                // Prompt user to choose a valid number (1-5).
                else
                {
                    Console.WriteLine("Please type a valid entry.");
                }
            }
        }
    }
}