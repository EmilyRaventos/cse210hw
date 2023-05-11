using System;
using Program;
using Journals;

namespace Entries
{
    public class Entry
    {
        public string _date;
        public string _prompt;
        public string _response;
        string _entry;

        public string CreateEntry(string prompt) 
        {
            // Write the prompt and save the response.
            Console.WriteLine(prompt);
            _response = Console.ReadLine();

            // Find and save today's date.
            DateTime theCurrentTime = DateTime.Now;
            _date = theCurrentTime.ToShortDateString();

            // Create the entry.
            _entry = $"Date: {_date} - Prompt: {prompt}\n{_response}\n";
            return _entry;
        }
    }
}