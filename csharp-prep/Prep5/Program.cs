using System;

class Program
{
    static void Main(string[] args)
    {
        //DisplayWelcome - Displays the message, "Welcome to the Program!" static function

        static void DisplayWelcome()
        {
            Console.WriteLine("Welcome to the Program!");
        }

        
        //Prompt User Name static function.
        static string GetUserName()
        {
            Console.Write("Please enter your username: ");
            string userName = Console.ReadLine();

            return userName;
        }

        //Ask for favorite number and return it.
        static int GetFavoriteNumber()
        {
            Console.Write("What is your favorite number? ");
            int userNumber = int.Parse(Console.ReadLine());

            return userNumber;
        }

        //Function that squares a number passed into.
        static int SquareNumber(int userNumber)
        {
            int squared = userNumber * userNumber;

            return squared;
        }

        //Function to display the results of the previous 4 funtions.
        static void DisplayOutput(string userName, int squared)
        {
            Console.WriteLine($"{userName}, the square of your favorite number is {squared}");
        }



        //Call the funtions
        DisplayWelcome();
        string userName = GetUserName();
        int userNumber = GetFavoriteNumber();
        int square = SquareNumber(userNumber);
        DisplayOutput(userName, square);


    }
    
}