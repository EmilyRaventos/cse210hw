using System;
using System.IO;
using Prompts;
using Journals;
using Entries;
using WelcomeUser;

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

                if (_choice == "1") 
                {
                    string newPrompt = prompt.GetPrompt();
                    _entry = entry.CreateEntry(newPrompt);
                    journal.AddToJournal(_entry);
                }
                else if (_choice == "2")
                {
                    journal.DisplayEntries();
                }
                else if (_choice == "3")
                {
                    journal.LoadJournal();
                }
                else if (_choice == "4")
                {
                    journal.SaveJournal();
                }
                else if (_choice == "5")
                {
                    _journalOpen = "no";
                }
                else
                {
                    Console.WriteLine("Please type a valid entry.");
                }
            }
        }
    }
}