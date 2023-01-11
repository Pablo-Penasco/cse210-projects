using System;

class Program
{
    static void Main(string[] args)
    {
        //Declare variable for user input.
        string userInput = "";

        //Create a list of intergers.
        List<int> numbers = new List<int>();

        //Ask for user to input a number. Keep adding it to the "numbers" list until they enter 0.
        while (userInput != "0")
        {
            
            Console.Write("Please add a number to the list. Enter 0 when you are done: ");
            userInput = Console.ReadLine();
            int userNumber = int.Parse(userInput);

            numbers.Add(userNumber);
        }
        
        

        

        

        
        
    }
}