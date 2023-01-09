using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Please enter a random number: ");
        string userRandomNumber = Console.ReadLine();
        int x = int.Parse(userRandomNumber);

        
        

        int guessNumber = 0;        


        while (guessNumber != x)
        {
            Console.Write("Guess the random number: ");
            string userInputGuess = Console.ReadLine();
            guessNumber = int.Parse(userInputGuess);
            
                if (guessNumber < x)
            {
                Console.WriteLine("Less");
            }
            else if (guessNumber > x)
            {
                Console.WriteLine("Greater");
            }
            else
            {
                Console.WriteLine("You guessed it! You must have ESPN!(joke) ");
            }
        }

    }
}