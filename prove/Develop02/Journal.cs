using System;
using Program;

namespace Journals
{
    public class Journal 
    {
        public List<string> _entries = new List<string> {};
        string _filename;

        // Add entries to the current journal list.
        public void AddToJournal(string entry)
        {
            _entries.Add(entry);
        }

        // Disiplay all entries found in current journal list.
        public void DisplayEntries() 
        {
            foreach (string entry in _entries)
            {
                Console.WriteLine(entry);
            }
        }

        // If there are entries to add, add them to 'myfile.txt' 
        public void SaveJournal()
        {
            Console.WriteLine("\nSaving file as 'myfile.txt' ... ");

            // Added so it won't clear file when 'save' is selected before entries are written
            bool isEmpty = _entries.Any();

            if (isEmpty)
            {
            _filename = "myfile.txt";
            using (StreamWriter outputfile = new StreamWriter(_filename))
            {
                foreach(string entry in _entries)
                {
                    outputfile.WriteLine(entry);
                }
            }
            }
        }

        // Load entries from a text file into the list of current entries.
        public List<string> LoadJournal()
        {
            Console.WriteLine("Enter the name of the file you would like to load: ");
            _filename = Console.ReadLine();
            Console.WriteLine("\nLoading file... ");

            string[] pastEntries = System.IO.File.ReadAllLines(_filename);
            _entries = pastEntries.ToList();
            return _entries;
        }
    }
}