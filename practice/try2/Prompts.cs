using System;
using Program;

namespace Prompts {
    public class Prompt
    {
        static string filename = "prompts.txt";
        static string[] prompts = System.IO.File.ReadAllLines(filename);
        Random rnd = new Random();
        int randomNumber;

        public string GetPrompt() {
            // Determine the number of prompts.
            int numPrompts = prompts.Count() - 1;

            // Generate a random number within the range of the number of prompts
            randomNumber = rnd.Next(0,numPrompts);

            // Randomly generate prompt.
            string newPrompt = prompts[randomNumber];
            return newPrompt;
        }
    }
}