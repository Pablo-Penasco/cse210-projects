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
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");
        while (userInput != "0")
        {
            
            Console.Write("Enter number: ");
            userInput = Console.ReadLine();
            int userNumber = int.Parse(userInput);

            if (userNumber !=0)
            {
                numbers.Add(userNumber);
            }
            
        }
        
        // Use Sum command to add numbers in the list.
        float total = numbers.Sum();
        Console.WriteLine($"The sum is: {total}");
        
        //Get the count of items in the list and divice the total by that.
        float count = numbers.Count();
        float average = total / count;
        Console.WriteLine($"The average is: {average}");

        //Find the largest number.
        int max = numbers.Max();
        Console.WriteLine($"The largest number is: {max}");

        

        
        
    }
}