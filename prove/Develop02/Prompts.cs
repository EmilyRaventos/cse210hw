using System;
using Program;

namespace Prompts
{
    public class Prompt
    {
        static string _filename = "prompts.txt";
        static string[] _prompts = System.IO.File.ReadAllLines(_filename);
        Random rnd = new Random();
        int _randomNumber;

        public string GetPrompt()
        {
            // Determine the number of prompts.
            int numPrompts = _prompts.Count() - 1;

            // Generate a random number within the range of the number of prompts
            _randomNumber = rnd.Next(0,numPrompts);

            // Randomly generate prompt.
            string newPrompt = _prompts[_randomNumber];
            return newPrompt;
        }
    }
}