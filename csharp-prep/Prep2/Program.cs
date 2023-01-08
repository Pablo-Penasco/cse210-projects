using System;

class Program
{
    static void Main(string[] args)
    {
    bool pass = true;
        string letter ="";

        Console.Write("What is your grade percentage? ");
        string gradeNumber = Console.ReadLine();
        int x = int.Parse(gradeNumber);

        if (x >= 90)
        {
            letter = "A";
            pass = true;
        }
        else if (x >= 80)
        {
            letter = "B";
            pass = true;
        }
        else if (x >= 70)
        {
            letter = "C";
            pass = true;
        }
        else if (x >= 60)
        {
            letter = "D";
            pass = false;
        }
        else
        {
            letter = "F";
            pass = false;
        }

        Console.WriteLine($"Your letter grade is {letter}.");

        if (pass == true)
        {
            Console.WriteLine("You passed the class. Great job!");
        }
        else
        {
            Console.WriteLine("You failed the class this time. Try again next semester. You got this!");
        }

    }
 }