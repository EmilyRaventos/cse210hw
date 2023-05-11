using System;
using System.IO;
using Prompts;
using Journals;
using Entries;

namespace Program {

    class Program 
    {
        static void Main(string[] args)
        {
            // Member variables
            string _journalOpen = "yes";
            string _choice;
            string _entry;

            string DisplayMenu() 
            {
                Console.WriteLine("Please select one of the following choices: ");
                Console.WriteLine("1. Write\n2. Display\n3. Load\n4. Save\n5. Quit");
                Console.WriteLine("What would you like to do?");
                string _choice = Console.ReadLine();
                return _choice;
            }

            // Create an instance/generate a prompt.
            Prompt prompt = new Prompt();

            // Create a journal list for the current entries.
            Journal journal = new Journal();

            // Create an entry to write the current response.
            Entry entry = new Entry();

            // Start of Program
            Console.WriteLine("Welcome to the Journal Program! ");

            while (_journalOpen == "yes") 
            {
               _choice = DisplayMenu();

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