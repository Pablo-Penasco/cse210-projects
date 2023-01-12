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
        static string GetUserName(string userName)
        {
            Console.Write("Please enter your username: ");
            userName = Console.ReadLine();

            return userName;
        }



        //Call the funtions
        DisplayWelcome();
        GetUserName();

    }
    
}