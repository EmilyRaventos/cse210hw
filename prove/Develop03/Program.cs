using System;
using ScriptureSpace;
using ReferenceSpace;
using WordSpace;

namespace ProgramSpace
{
    class Program
    {
        static void Main()
        {
            // Read the scripture.txt file into a list
            string[] scriptureTexts = System.IO.File.ReadAllLines("scripture.txt");
            List<string> scriptures = scriptureTexts.ToList();

            // Generate a random index
            Random rnd = new Random();
            int _randomIndex = rnd.Next(0, scriptures.Count);  

            // Pick a random scripture using the randomly generated index
            string _chosenScripture = scriptures[_randomIndex];
            bool _end = false;

            while (_end == false)
            {
                // Display scripture and prompt user for enter or 'quit'
                Console.WriteLine(_chosenScripture);
                Console.WriteLine("Please press Enter to continue or press Esc to finish: ");

                // If enter, hide a word three times
                if (Console.ReadKey().Key == ConsoleKey.Enter)
                {
                    // Hide 3 words of the scripture
                    Console.WriteLine("Hide a word three times");

                    // Update chosen scripture to include the hidden words
                }

                // If Esc, set _end to 'true' to exit loop
                else if (Console.ReadKey().Key == ConsoleKey.Escape)
                {
                    _end = true;
                    Console.WriteLine("Good Bye.");
                }

                // Prompt user for valid choice
                else
                {
                    Console.WriteLine("Please press Enter to continue or Esc to finish.");
                }
            
                Console.Clear();
            }
        }
    }
}