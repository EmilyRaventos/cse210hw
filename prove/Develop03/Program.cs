using System;
using References;
using Scriptures;
using Words;
using System.Text;

namespace Program1
{
    class Program1
    {
        static void Main(string[] args)
        {
            ConsoleKeyInfo pressedKey = new ConsoleKeyInfo();

            Console.WriteLine("Welcome to the Scripture Memorizing Program!\n");

            // Display selected scripture
            Reference reference = new Reference("Proverbs", "3", "5", "6");
            Scripture scripture = new Scripture(reference, "Trust in the Lord with all thy heart and lean not unto thy own understanding; in all thy ways acknowledge him, and he shall direct thy paths.");
            Console.WriteLine(scripture.GetRenderedText());

            Console.Write("\nPress ENTER to continue or press Esc to quit. ");
            pressedKey = Console.ReadKey();

            bool _isHidden = scripture.IsCompletelyHidden();
            bool _isComplete = false;
            int hiddenWordCount =  0;

            while (_isHidden == false && _isComplete == false)
            {
                int wordObjectCount = scripture.GetWordCount();

                if (pressedKey.Key == ConsoleKey.Enter)
                {
                    // Hide 3 words at a time
                    scripture.HideWords();
                    scripture.HideWords();
                    scripture.HideWords();

                    hiddenWordCount += 3;

                    // Clear the Console
                    Console.Clear();

                    // Display the scripture with some words hidden
                    Console.WriteLine("Welcome to the Scripture Memorizing Program!");
                    Console.WriteLine(scripture.GetRenderedText());
                    Console.Write("\nPress ENTER to continue or press Esc to quit. ");
                    pressedKey = Console.ReadKey();

                    // Check if scripture is completely hidden
                    _isHidden = scripture.IsCompletelyHidden();
                }

                // Quit program if user types "exit"
                else if (pressedKey.Key == ConsoleKey.Escape)
                {
                    _isComplete = true;
                }

                // Make sure user enters valid selection (ENTER or "exit")
                else
                {
                    Console.WriteLine("Not a valid selection.");
                    Console.Write("Please press ENTER to continue or type \"exit\" to quit. ");
                }

                // End loop if all words are hidden
                if (pressedKey.Key == ConsoleKey.Enter && wordObjectCount == hiddenWordCount)
                {
                    break;
                }
            }
            
            Console.WriteLine("\nThank you, good Bye.");
        }
    }
}
