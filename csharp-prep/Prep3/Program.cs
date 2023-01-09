using System;

class Program
{
    static void Main(string[] args)
    {
        // Generate a random number.
        Random randomGenerator = new Random();
        int x = randomGenerator.Next(1, 100);
        
        //Declare a variable for the user input.
        int guessNumber = 0;        

        //Take user input and compare to random number {x} until user input matches the random number.
        while (guessNumber != x)
        {
            Console.Write("What is your guess? ");
            string userInputGuess = Console.ReadLine();
            guessNumber = int.Parse(userInputGuess);
            
                if (guessNumber < x)
            {
                Console.WriteLine("Higher");
            }
            else if (guessNumber > x)
            {
                Console.WriteLine("Lower");
            }
            else
            {
                Console.WriteLine("You guessed it! You must have ESPN!(joke) ");
            }
        }

    }
}