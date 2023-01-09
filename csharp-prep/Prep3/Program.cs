using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Please enter a random number: ");
        string userRandomNumber = Console.ReadLine();
        int x = int.Parse(userRandomNumber);

        
        Console.Write("Guess the random number: ");
        string userInputGuess = Console.ReadLine();
        int guessNumber = int.Parse(userInputGuess);

        if (guessNumber < x)
        {
            Console.WriteLine("Less");
        }

        if (guessNumber > x)
        {
            Console.WriteLine("Greater");
        }

        if (guessNumber == x)
        {
            Console.WriteLine("Correct!");
        }

    }
}