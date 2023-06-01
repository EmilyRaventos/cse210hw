using System;
using References;
using Scriptures;
using Words;

namespace Program1
{
    class Program1
    {
        static void Main(string[] args)
        {
            // // Read all scriptures from scriptures.txt to a list
            // string[] scriptures = System.IO.File.ReadAllLines("scriptures.txt");
            // _scriptures = scriptures.ToList();
            // scripture.Split("~");

            // string[] scriptures = System.IO.File.ReadAllLines("scriptures.txt");
            // List<string> _scriptures = scriptures.ToList();

            // // Select a random scripture from the loaded list and create an instance of it
            // Random random = new Random();
            // int randomIndex = random.Next(0, scriptures.Count);
            // Scripture scripture = scriptures[randomIndex];

            Console.WriteLine("Welcome to the Scripture Memorizing Program!\n");

            // Display selected scripture
            Reference reference = new Reference("Proverbs", "3", "5", "6");
            Scripture scripture = new Scripture(reference, "Trust in the Lord with all thy heart and lean not unto thy own understanding; in all thy ways acknowledge him, and he shall direct thy paths.");
            Console.WriteLine(scripture.GetRenderedText());

            Console.Write("\nPress ENTER to continue or type \"exit\" to quit. ");

            bool _isHidden = scripture.IsCompletelyHidden();
            bool _isComplete = false;

            while (_isHidden == false && _isComplete == false)
            {
                int hiddenWordCount = scripture.GetWordCount();
                int wordObjectCount = scripture.GetWordCount();
                string userInput = Console.ReadLine();

                if (userInput == "")
                {
                    // Hide 3 words at a time
                    scripture.HideWords();
                    scripture.HideWords();
                    scripture.HideWords();

                    hiddenWordCount = scripture.GetWordCount();

                    // Clear the Console
                    Console.Clear();

                    // Display the scripture with some words hidden
                    Console.WriteLine("Welcome to the Scripture Memorizing Program!");
                    Console.WriteLine(scripture.GetRenderedText());
                    Console.Write("\nPress ENTER to continue or type \"exit\" to quit. ");

                    // Check if scripture is completely hidden
                    _isHidden = scripture.IsCompletelyHidden();
                }

                // Quit program if user types "exit"
                else if (userInput == "exit")
                {
                    _isComplete = true;
                }

                // Make sure user enters valid selection (ENTER or "exit")
                else
                {
                    Console.WriteLine("Not a valid selection.");
                    Console.Write("Please press ENTER to continue or type \"exit\" to quit. ");
                }
            }
            
            Console.WriteLine("Thank you, good Bye.");
        }
    }
}
