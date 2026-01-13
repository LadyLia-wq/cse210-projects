using System;

class Program
{
    static void Main(string[] args)
    {
        string playAgain = "yes";

        while (playAgain.ToLower() == "yes")
        {
            // Generate random magic number
            Random random = new Random();
            int magicNumber = random.Next(1, 101);

            int guess = 0;
            int guessCount = 0;

            // Loop until the user guesses the number
            while (guess != magicNumber)
            {
                Console.Write("What is your guess? ");
                guess = int.Parse(Console.ReadLine());
                guessCount++;

                if (guess < magicNumber)
                {
                    Console.WriteLine("Higher");
                }
                else if (guess > magicNumber)
                {
                    Console.WriteLine("Lower");
                }
                else
                {
                    Console.WriteLine("You guessed it!");
                }
            }

            // Display number of guesses
            Console.WriteLine($"It took you {guessCount} guesses.");

            // Ask to play again
            Console.Write("Do you want to play again? (yes/no) ");
            playAgain = Console.ReadLine();
        }
    }
}