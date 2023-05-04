using System;

internal class NewBaseType
{
    static void Main(string[] args)
    {
        // Introduce the user to the game.
        Console.WriteLine("Try to find the magic number between 1 and 10");
        string playAgain = "y";

        while (playAgain == "y")
        {
            string stillPlaying = "y";
            int guesses = 0;

            // Generate a random number.
            Random randomGenerator = new Random();
            int magicNumber = randomGenerator.Next(1, 11);

            while (stillPlaying == "y")
            {
                // Start the game.
                Console.Write("What is your guess? ");
                int guess = int.Parse(Console.ReadLine());
                guesses += 1;

                // Determine if the user's guess is too high, too low, or correct.
                if (guess > magicNumber)
                {
                    Console.WriteLine("Too High!");
                }
                else if (guess < magicNumber)
                {
                    Console.WriteLine("Too Low!");
                }
                else
                {
                    Console.WriteLine($"You guessed it! It took you {guesses} guesses");
                    stillPlaying = "n";
                }
            }

            // Ask the user if they want to play again.
            Console.Write("Do you want to play again (y/n)? ");
            playAgain = Console.ReadLine();

            // If the user doesn't want to play again, exit the loops.
            if (playAgain.ToLower() != "yes" && playAgain.ToLower() != "y")
            {
                playAgain = "n";
                Console.WriteLine("Thanks for playing!");
            }
        }
    }
}
